using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDbTelefonRehberi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TelefonRehberiDbEntities db;
        private void Form1_Load(object sender, EventArgs e)
        {
            //sqlde bir db oluşturun bu db nin adı TelefonRehberiDb olsun.
            //kisiler tablosu olsun,kisiId,ad,soyad,telefonu
            //dv first yaklaşımı ile
            db = new TelefonRehberiDbEntities();
            dataGridView1.DataSource = db.Kisilers.ToList();
            KisileriYukle();
        }

        private void KisileriYukle()
        {
            listView1.Items.Clear();
            List<Kisiler> kisiListesi = db.Kisilers.ToList();

            foreach (var kisi in kisiListesi)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Tag = kisi;

                lvi.Text = kisi.KisiId.ToString();
                lvi.SubItems.Add(kisi.Adi);
                lvi.SubItems.Add(kisi.Soyadi);
                lvi.SubItems.Add(kisi.Telefonu);

                listView1.Items.Add(lvi);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text) || string.IsNullOrEmpty(txtTelefon.Text))
            {
                MessageBox.Show("bilgileri giriniz.");
            }
            else
            {
                if (btnKaydet.Text == "kaydet")
                {
                    Kisiler kisi = new Kisiler();
                    kisi.Adi = txtAd.Text;
                    kisi.Soyadi = txtSoyad.Text;
                    kisi.Telefonu = txtTelefon.Text;

                    db.Kisilers.Add(kisi);
                    int kaydettiMi = 0;
                    kaydettiMi = db.SaveChanges();//yapılan eklemeyi kaydeder yazar
                    if (kaydettiMi > 0)
                    {
                        MessageBox.Show("kisi eklendi");
                        dataGridView1.DataSource = db.Kisilers.ToList();//gridi doldurucak
                        KisileriYukle();
                    }
                }
                else
                {
                    guncellenecekKisi.Adi = txtAd.Text;
                    guncellenecekKisi.Soyadi = txtSoyad.Text;
                    guncellenecekKisi.Telefonu = txtTelefon.Text;
                    db.SaveChanges();
                    btnKaydet.Text = "kaydet";
                    KisileriYukle();
                }
                txtAd.Text = txtSoyad.Text = txtTelefon.Text = "";
            }  
        }
        Kisiler guncellenecekKisi;
        private void CmsGuncelle_Click(object sender, EventArgs e)
        {
            guncellenecekKisi = (Kisiler)listView1.SelectedItems[0].Tag;
            txtAd.Text = guncellenecekKisi.Adi;
            txtSoyad.Text = guncellenecekKisi.Soyadi;
            txtTelefon.Text = guncellenecekKisi.Telefonu;
            btnKaydet.Text = "Güncelle";
           


        }

        private void CmsSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count <= 0)
            {
                return;
            }
            // listView1.SelectedItems[0]//listview item
            
            //listView1.SelectedItems[0].Text//kisinin ıd
            
            Kisiler kisi = (Kisiler)listView1.SelectedItems[0].Tag;
           DialogResult dialog= MessageBox.Show("silmek istediğinize emin misiniz?","Uyarı!",MessageBoxButtons.YesNo);
            if (dialog==DialogResult.Yes)
            {
                db.Kisilers.Remove(kisi);//entity ile silme
                int basarili = 0;
                basarili = db.SaveChanges();
                if (basarili > 0)
                {
                    KisileriYukle();
                    MessageBox.Show("kişi silinmiştir.");
                }
                else
                {
                    MessageBox.Show("silinemedi.");
                }
            }
          

           
        }
    }
}
