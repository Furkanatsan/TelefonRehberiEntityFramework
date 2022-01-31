
namespace EntityFrameworkGiris
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.northwindDataSet = new EntityFrameworkGiris.NorthwindDataSet();
            this.personellerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personellerTableAdapter = new EntityFrameworkGiris.NorthwindDataSetTableAdapters.PersonellerTableAdapter();
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unvanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unvanEkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıseBaslamaTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postaKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evTelefonuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extensionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotografDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.notlarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagliCalistigiKisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotografPathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personellerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(449, 356);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelIDDataGridViewTextBoxColumn,
            this.soyAdiDataGridViewTextBoxColumn,
            this.adiDataGridViewTextBoxColumn,
            this.unvanDataGridViewTextBoxColumn,
            this.unvanEkiDataGridViewTextBoxColumn,
            this.dogumTarihiDataGridViewTextBoxColumn,
            this.ıseBaslamaTarihiDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.sehirDataGridViewTextBoxColumn,
            this.bolgeDataGridViewTextBoxColumn,
            this.postaKoduDataGridViewTextBoxColumn,
            this.ulkeDataGridViewTextBoxColumn,
            this.evTelefonuDataGridViewTextBoxColumn,
            this.extensionDataGridViewTextBoxColumn,
            this.fotografDataGridViewImageColumn,
            this.notlarDataGridViewTextBoxColumn,
            this.bagliCalistigiKisiDataGridViewTextBoxColumn,
            this.fotografPathDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.personellerBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(535, 38);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(553, 356);
            this.dataGridView2.TabIndex = 0;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personellerBindingSource
            // 
            this.personellerBindingSource.DataMember = "Personeller";
            this.personellerBindingSource.DataSource = this.northwindDataSet;
            // 
            // personellerTableAdapter
            // 
            this.personellerTableAdapter.ClearBeforeFill = true;
            // 
            // personelIDDataGridViewTextBoxColumn
            // 
            this.personelIDDataGridViewTextBoxColumn.DataPropertyName = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.HeaderText = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelIDDataGridViewTextBoxColumn.Name = "personelIDDataGridViewTextBoxColumn";
            this.personelIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personelIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyAdiDataGridViewTextBoxColumn
            // 
            this.soyAdiDataGridViewTextBoxColumn.DataPropertyName = "SoyAdi";
            this.soyAdiDataGridViewTextBoxColumn.HeaderText = "SoyAdi";
            this.soyAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyAdiDataGridViewTextBoxColumn.Name = "soyAdiDataGridViewTextBoxColumn";
            this.soyAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // adiDataGridViewTextBoxColumn
            // 
            this.adiDataGridViewTextBoxColumn.DataPropertyName = "Adi";
            this.adiDataGridViewTextBoxColumn.HeaderText = "Adi";
            this.adiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adiDataGridViewTextBoxColumn.Name = "adiDataGridViewTextBoxColumn";
            this.adiDataGridViewTextBoxColumn.Width = 125;
            // 
            // unvanDataGridViewTextBoxColumn
            // 
            this.unvanDataGridViewTextBoxColumn.DataPropertyName = "Unvan";
            this.unvanDataGridViewTextBoxColumn.HeaderText = "Unvan";
            this.unvanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unvanDataGridViewTextBoxColumn.Name = "unvanDataGridViewTextBoxColumn";
            this.unvanDataGridViewTextBoxColumn.Width = 125;
            // 
            // unvanEkiDataGridViewTextBoxColumn
            // 
            this.unvanEkiDataGridViewTextBoxColumn.DataPropertyName = "UnvanEki";
            this.unvanEkiDataGridViewTextBoxColumn.HeaderText = "UnvanEki";
            this.unvanEkiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unvanEkiDataGridViewTextBoxColumn.Name = "unvanEkiDataGridViewTextBoxColumn";
            this.unvanEkiDataGridViewTextBoxColumn.Width = 125;
            // 
            // dogumTarihiDataGridViewTextBoxColumn
            // 
            this.dogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "DogumTarihi";
            this.dogumTarihiDataGridViewTextBoxColumn.HeaderText = "DogumTarihi";
            this.dogumTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dogumTarihiDataGridViewTextBoxColumn.Name = "dogumTarihiDataGridViewTextBoxColumn";
            this.dogumTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıseBaslamaTarihiDataGridViewTextBoxColumn
            // 
            this.ıseBaslamaTarihiDataGridViewTextBoxColumn.DataPropertyName = "IseBaslamaTarihi";
            this.ıseBaslamaTarihiDataGridViewTextBoxColumn.HeaderText = "IseBaslamaTarihi";
            this.ıseBaslamaTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıseBaslamaTarihiDataGridViewTextBoxColumn.Name = "ıseBaslamaTarihiDataGridViewTextBoxColumn";
            this.ıseBaslamaTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 125;
            // 
            // sehirDataGridViewTextBoxColumn
            // 
            this.sehirDataGridViewTextBoxColumn.DataPropertyName = "Sehir";
            this.sehirDataGridViewTextBoxColumn.HeaderText = "Sehir";
            this.sehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sehirDataGridViewTextBoxColumn.Name = "sehirDataGridViewTextBoxColumn";
            this.sehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // bolgeDataGridViewTextBoxColumn
            // 
            this.bolgeDataGridViewTextBoxColumn.DataPropertyName = "Bolge";
            this.bolgeDataGridViewTextBoxColumn.HeaderText = "Bolge";
            this.bolgeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolgeDataGridViewTextBoxColumn.Name = "bolgeDataGridViewTextBoxColumn";
            this.bolgeDataGridViewTextBoxColumn.Width = 125;
            // 
            // postaKoduDataGridViewTextBoxColumn
            // 
            this.postaKoduDataGridViewTextBoxColumn.DataPropertyName = "PostaKodu";
            this.postaKoduDataGridViewTextBoxColumn.HeaderText = "PostaKodu";
            this.postaKoduDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.postaKoduDataGridViewTextBoxColumn.Name = "postaKoduDataGridViewTextBoxColumn";
            this.postaKoduDataGridViewTextBoxColumn.Width = 125;
            // 
            // ulkeDataGridViewTextBoxColumn
            // 
            this.ulkeDataGridViewTextBoxColumn.DataPropertyName = "Ulke";
            this.ulkeDataGridViewTextBoxColumn.HeaderText = "Ulke";
            this.ulkeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ulkeDataGridViewTextBoxColumn.Name = "ulkeDataGridViewTextBoxColumn";
            this.ulkeDataGridViewTextBoxColumn.Width = 125;
            // 
            // evTelefonuDataGridViewTextBoxColumn
            // 
            this.evTelefonuDataGridViewTextBoxColumn.DataPropertyName = "EvTelefonu";
            this.evTelefonuDataGridViewTextBoxColumn.HeaderText = "EvTelefonu";
            this.evTelefonuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.evTelefonuDataGridViewTextBoxColumn.Name = "evTelefonuDataGridViewTextBoxColumn";
            this.evTelefonuDataGridViewTextBoxColumn.Width = 125;
            // 
            // extensionDataGridViewTextBoxColumn
            // 
            this.extensionDataGridViewTextBoxColumn.DataPropertyName = "Extension";
            this.extensionDataGridViewTextBoxColumn.HeaderText = "Extension";
            this.extensionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.extensionDataGridViewTextBoxColumn.Name = "extensionDataGridViewTextBoxColumn";
            this.extensionDataGridViewTextBoxColumn.Width = 125;
            // 
            // fotografDataGridViewImageColumn
            // 
            this.fotografDataGridViewImageColumn.DataPropertyName = "Fotograf";
            this.fotografDataGridViewImageColumn.HeaderText = "Fotograf";
            this.fotografDataGridViewImageColumn.MinimumWidth = 6;
            this.fotografDataGridViewImageColumn.Name = "fotografDataGridViewImageColumn";
            this.fotografDataGridViewImageColumn.Width = 125;
            // 
            // notlarDataGridViewTextBoxColumn
            // 
            this.notlarDataGridViewTextBoxColumn.DataPropertyName = "Notlar";
            this.notlarDataGridViewTextBoxColumn.HeaderText = "Notlar";
            this.notlarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notlarDataGridViewTextBoxColumn.Name = "notlarDataGridViewTextBoxColumn";
            this.notlarDataGridViewTextBoxColumn.Width = 125;
            // 
            // bagliCalistigiKisiDataGridViewTextBoxColumn
            // 
            this.bagliCalistigiKisiDataGridViewTextBoxColumn.DataPropertyName = "BagliCalistigiKisi";
            this.bagliCalistigiKisiDataGridViewTextBoxColumn.HeaderText = "BagliCalistigiKisi";
            this.bagliCalistigiKisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bagliCalistigiKisiDataGridViewTextBoxColumn.Name = "bagliCalistigiKisiDataGridViewTextBoxColumn";
            this.bagliCalistigiKisiDataGridViewTextBoxColumn.Width = 125;
            // 
            // fotografPathDataGridViewTextBoxColumn
            // 
            this.fotografPathDataGridViewTextBoxColumn.DataPropertyName = "FotografPath";
            this.fotografPathDataGridViewTextBoxColumn.HeaderText = "FotografPath";
            this.fotografPathDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fotografPathDataGridViewTextBoxColumn.Name = "fotografPathDataGridViewTextBoxColumn";
            this.fotografPathDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personellerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource personellerBindingSource;
        private NorthwindDataSetTableAdapters.PersonellerTableAdapter personellerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unvanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unvanEkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıseBaslamaTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postaKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evTelefonuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extensionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotografDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notlarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagliCalistigiKisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fotografPathDataGridViewTextBoxColumn;
    }
}

