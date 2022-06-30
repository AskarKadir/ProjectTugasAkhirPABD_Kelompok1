
namespace UASKELOMPOK
{
    partial class AdminDashboard
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
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.textBoxNamaSiswaAdmin = new System.Windows.Forms.TextBox();
            this.textBoxTanggalLahir = new System.Windows.Forms.TextBox();
            this.textBoxWali = new System.Windows.Forms.TextBox();
            this.textBoxHasil = new System.Windows.Forms.TextBox();
            this.textBoxTingkatanKelas = new System.Windows.Forms.TextBox();
            this.textBoxNISNAdmin = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.textBoxPencarian = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelWaliKelas = new System.Windows.Forms.Label();
            this.labelHasilSiswa = new System.Windows.Forms.Label();
            this.labelTingkatanKelas = new System.Windows.Forms.Label();
            this.labelTanggalLahir = new System.Windows.Forms.Label();
            this.labelNISN = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.tugasakhirpart3DataSet3 = new UASKELOMPOK.tugasakhirpart3DataSet();
            this.tampilanAdminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tampilanAdminTableAdapter2 = new UASKELOMPOK.tugasakhirpart3DataSetTableAdapters.tampilanAdminTableAdapter();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasakhirpart3DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tampilanAdminBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.AllowUserToOrderColumns = true;
            this.dataGridViewAdmin.AutoGenerateColumns = false;
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dataGridViewAdmin.DataSource = this.tampilanAdminBindingSource;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(16, 136);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.Size = new System.Drawing.Size(648, 328);
            this.dataGridViewAdmin.TabIndex = 0;
            this.dataGridViewAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxNamaSiswaAdmin
            // 
            this.textBoxNamaSiswaAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNamaSiswaAdmin.Location = new System.Drawing.Point(680, 160);
            this.textBoxNamaSiswaAdmin.Name = "textBoxNamaSiswaAdmin";
            this.textBoxNamaSiswaAdmin.ReadOnly = true;
            this.textBoxNamaSiswaAdmin.Size = new System.Drawing.Size(128, 26);
            this.textBoxNamaSiswaAdmin.TabIndex = 1;
            // 
            // textBoxTanggalLahir
            // 
            this.textBoxTanggalLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTanggalLahir.Location = new System.Drawing.Point(680, 240);
            this.textBoxTanggalLahir.Name = "textBoxTanggalLahir";
            this.textBoxTanggalLahir.ReadOnly = true;
            this.textBoxTanggalLahir.Size = new System.Drawing.Size(128, 26);
            this.textBoxTanggalLahir.TabIndex = 2;
            // 
            // textBoxWali
            // 
            this.textBoxWali.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWali.Location = new System.Drawing.Point(680, 320);
            this.textBoxWali.Name = "textBoxWali";
            this.textBoxWali.Size = new System.Drawing.Size(128, 26);
            this.textBoxWali.TabIndex = 3;
            // 
            // textBoxHasil
            // 
            this.textBoxHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHasil.Location = new System.Drawing.Point(944, 320);
            this.textBoxHasil.Name = "textBoxHasil";
            this.textBoxHasil.Size = new System.Drawing.Size(128, 26);
            this.textBoxHasil.TabIndex = 6;
            // 
            // textBoxTingkatanKelas
            // 
            this.textBoxTingkatanKelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTingkatanKelas.Location = new System.Drawing.Point(944, 240);
            this.textBoxTingkatanKelas.Name = "textBoxTingkatanKelas";
            this.textBoxTingkatanKelas.Size = new System.Drawing.Size(128, 26);
            this.textBoxTingkatanKelas.TabIndex = 5;
            // 
            // textBoxNISNAdmin
            // 
            this.textBoxNISNAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNISNAdmin.Location = new System.Drawing.Point(944, 160);
            this.textBoxNISNAdmin.Name = "textBoxNISNAdmin";
            this.textBoxNISNAdmin.ReadOnly = true;
            this.textBoxNISNAdmin.Size = new System.Drawing.Size(128, 26);
            this.textBoxNISNAdmin.TabIndex = 4;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(680, 424);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(128, 31);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(944, 424);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(128, 31);
            this.buttonSimpan.TabIndex = 8;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // textBoxPencarian
            // 
            this.textBoxPencarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPencarian.Location = new System.Drawing.Point(16, 88);
            this.textBoxPencarian.Name = "textBoxPencarian";
            this.textBoxPencarian.Size = new System.Drawing.Size(424, 26);
            this.textBoxPencarian.TabIndex = 9;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(560, 88);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(104, 31);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelWaliKelas
            // 
            this.labelWaliKelas.AutoSize = true;
            this.labelWaliKelas.BackColor = System.Drawing.Color.Transparent;
            this.labelWaliKelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWaliKelas.Location = new System.Drawing.Point(680, 296);
            this.labelWaliKelas.Name = "labelWaliKelas";
            this.labelWaliKelas.Size = new System.Drawing.Size(72, 16);
            this.labelWaliKelas.TabIndex = 11;
            this.labelWaliKelas.Text = "Wali Kelas";
            // 
            // labelHasilSiswa
            // 
            this.labelHasilSiswa.AutoSize = true;
            this.labelHasilSiswa.BackColor = System.Drawing.Color.Transparent;
            this.labelHasilSiswa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHasilSiswa.Location = new System.Drawing.Point(944, 296);
            this.labelHasilSiswa.Name = "labelHasilSiswa";
            this.labelHasilSiswa.Size = new System.Drawing.Size(78, 16);
            this.labelHasilSiswa.TabIndex = 12;
            this.labelHasilSiswa.Text = "Hasil Siswa";
            // 
            // labelTingkatanKelas
            // 
            this.labelTingkatanKelas.AutoSize = true;
            this.labelTingkatanKelas.BackColor = System.Drawing.Color.Transparent;
            this.labelTingkatanKelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTingkatanKelas.Location = new System.Drawing.Point(944, 216);
            this.labelTingkatanKelas.Name = "labelTingkatanKelas";
            this.labelTingkatanKelas.Size = new System.Drawing.Size(105, 16);
            this.labelTingkatanKelas.TabIndex = 14;
            this.labelTingkatanKelas.Text = "Tingkatan Kelas";
            // 
            // labelTanggalLahir
            // 
            this.labelTanggalLahir.AutoSize = true;
            this.labelTanggalLahir.BackColor = System.Drawing.Color.Transparent;
            this.labelTanggalLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTanggalLahir.Location = new System.Drawing.Point(680, 216);
            this.labelTanggalLahir.Name = "labelTanggalLahir";
            this.labelTanggalLahir.Size = new System.Drawing.Size(91, 16);
            this.labelTanggalLahir.TabIndex = 13;
            this.labelTanggalLahir.Text = "Tanggal Lahir";
            // 
            // labelNISN
            // 
            this.labelNISN.AutoSize = true;
            this.labelNISN.BackColor = System.Drawing.Color.Transparent;
            this.labelNISN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNISN.Location = new System.Drawing.Point(944, 136);
            this.labelNISN.Name = "labelNISN";
            this.labelNISN.Size = new System.Drawing.Size(40, 16);
            this.labelNISN.TabIndex = 16;
            this.labelNISN.Text = "NISN";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.BackColor = System.Drawing.Color.Transparent;
            this.labelNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(680, 136);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(84, 16);
            this.labelNama.TabIndex = 15;
            this.labelNama.Text = "Nama Siswa";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(448, 88);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(104, 31);
            this.buttonReset.TabIndex = 17;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // tugasakhirpart3DataSet3
            // 
            this.tugasakhirpart3DataSet3.DataSetName = "tugasakhirpart3DataSet";
            this.tugasakhirpart3DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tampilanAdminBindingSource
            // 
            this.tampilanAdminBindingSource.DataMember = "tampilanAdmin";
            this.tampilanAdminBindingSource.DataSource = this.tugasakhirpart3DataSet3;
            // 
            // tampilanAdminTableAdapter2
            // 
            this.tampilanAdminTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Nama_Siswa";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nama_Siswa";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "NISN";
            this.dataGridViewTextBoxColumn8.HeaderText = "NISN";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Tanggal_Lahir";
            this.dataGridViewTextBoxColumn9.HeaderText = "Tanggal_Lahir";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Tingkatan_Kelas";
            this.dataGridViewTextBoxColumn10.HeaderText = "Tingkatan_Kelas";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Wali_Kelas";
            this.dataGridViewTextBoxColumn11.HeaderText = "Wali_Kelas";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Hasil_Siswa";
            this.dataGridViewTextBoxColumn12.HeaderText = "Hasil_Siswa";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(16, 8);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(128, 31);
            this.buttonLogout.TabIndex = 18;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1197, 486);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelNISN);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.labelTingkatanKelas);
            this.Controls.Add(this.labelTanggalLahir);
            this.Controls.Add(this.labelHasilSiswa);
            this.Controls.Add(this.labelWaliKelas);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxPencarian);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxHasil);
            this.Controls.Add(this.textBoxTingkatanKelas);
            this.Controls.Add(this.textBoxNISNAdmin);
            this.Controls.Add(this.textBoxWali);
            this.Controls.Add(this.textBoxTanggalLahir);
            this.Controls.Add(this.textBoxNamaSiswaAdmin);
            this.Controls.Add(this.dataGridViewAdmin);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasakhirpart3DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tampilanAdminBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private tugasakhirpart3DataSet tugasakhirpart3DataSet;
        private tugasakhirpart3DataSetTableAdapters.tampilanAdminTableAdapter tampilanAdminTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaSiswaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nISNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalLahirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tingkatanKelasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waliKelasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasilSiswaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxNamaSiswaAdmin;
        private System.Windows.Forms.TextBox textBoxTanggalLahir;
        private System.Windows.Forms.TextBox textBoxWali;
        private System.Windows.Forms.TextBox textBoxHasil;
        private System.Windows.Forms.TextBox textBoxTingkatanKelas;
        private System.Windows.Forms.TextBox textBoxNISNAdmin;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.TextBox textBoxPencarian;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelWaliKelas;
        private System.Windows.Forms.Label labelHasilSiswa;
        private System.Windows.Forms.Label labelTingkatanKelas;
        private System.Windows.Forms.Label labelTanggalLahir;
        private System.Windows.Forms.Label labelNISN;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Button buttonReset;
        private tugasakhirpart3DataSet tugasakhirpart3DataSet1;
        private tugasakhirpart3DataSet tugasakhirpart3DataSet2;
        private tugasakhirpart3DataSetTableAdapters.tampilanAdminTableAdapter tampilanAdminTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private tugasakhirpart3DataSet tugasakhirpart3DataSet3;
        private System.Windows.Forms.BindingSource tampilanAdminBindingSource;
        private tugasakhirpart3DataSetTableAdapters.tampilanAdminTableAdapter tampilanAdminTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button buttonLogout;
    }
}