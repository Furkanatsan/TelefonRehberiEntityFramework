using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Personeller' table. You can move, or remove it, as needed.
            this.personellerTableAdapter.Fill(this.northwindDataSet.Personeller);
            //ebtity framework adonet alt yapısını kullanır.
            //ORM(object relational mapping):ilişkisel veri tabanı ile oop projeleri arasında köprüdür.
            //entitiy avantajları
            //veri tabanına bağımlılığı azaltır.
            //db işlemlerşnde nesneye yönelik kod yazmamızı sağlar.
            //az zamanda çok iş yaptırır.
            //attributeler sayesinde şartlar oluşturulabilir.
            //kodlarda CRUD işlemlerinde kolaylık sağlar.
            NorthwindEntities db = new NorthwindEntities();
          // dataGridView1.DataSource=db.Personeller.ToList();
            dataGridView1.DataSource = db.Personeller.Where(a=>a.Bolge=="WA").ToList();//bölgesi wa olanları listeler dgv dde

           //personellerBindingSource.DataSource = db.Personeller.ToList();
        }
    }
}
