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
        }
    }
}
