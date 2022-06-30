
namespace UASKELOMPOK
{
    partial class Daftar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Daftar));
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxNISN = new System.Windows.Forms.TextBox();
            this.textBoxWali = new System.Windows.Forms.TextBox();
            this.textBoxNoWali = new System.Windows.Forms.TextBox();
            this.radioButtonLaki = new System.Windows.Forms.RadioButton();
            this.radioButtonWanita = new System.Windows.Forms.RadioButton();
            this.buttonKonfirmasi = new System.Windows.Forms.Button();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.dateTimePickerTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNamaSekolah = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxNama
            // 
            this.textBoxNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNama.ForeColor = System.Drawing.Color.Gray;
            this.textBoxNama.Location = new System.Drawing.Point(618, 112);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(208, 26);
            this.textBoxNama.TabIndex = 0;
            this.textBoxNama.TabStop = false;
            this.textBoxNama.Text = "Nama";
            this.textBoxNama.Click += new System.EventHandler(this.textBoxNama_Click);
            // 
            // textBoxNISN
            // 
            this.textBoxNISN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNISN.ForeColor = System.Drawing.Color.Gray;
            this.textBoxNISN.Location = new System.Drawing.Point(618, 160);
            this.textBoxNISN.MaxLength = 8;
            this.textBoxNISN.Name = "textBoxNISN";
            this.textBoxNISN.Size = new System.Drawing.Size(208, 26);
            this.textBoxNISN.TabIndex = 1;
            this.textBoxNISN.TabStop = false;
            this.textBoxNISN.Text = "NISN";
            this.textBoxNISN.Click += new System.EventHandler(this.textBoxNISN_Click);
            this.textBoxNISN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNISN_KeyPress);
            // 
            // textBoxWali
            // 
            this.textBoxWali.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWali.ForeColor = System.Drawing.Color.Gray;
            this.textBoxWali.Location = new System.Drawing.Point(618, 328);
            this.textBoxWali.Name = "textBoxWali";
            this.textBoxWali.Size = new System.Drawing.Size(208, 26);
            this.textBoxWali.TabIndex = 3;
            this.textBoxWali.TabStop = false;
            this.textBoxWali.Text = "Nama Orang Tua/Wali";
            this.textBoxWali.Click += new System.EventHandler(this.textBoxWali_Click);
            // 
            // textBoxNoWali
            // 
            this.textBoxNoWali.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoWali.ForeColor = System.Drawing.Color.Gray;
            this.textBoxNoWali.Location = new System.Drawing.Point(618, 376);
            this.textBoxNoWali.MaxLength = 13;
            this.textBoxNoWali.Name = "textBoxNoWali";
            this.textBoxNoWali.Size = new System.Drawing.Size(208, 26);
            this.textBoxNoWali.TabIndex = 4;
            this.textBoxNoWali.TabStop = false;
            this.textBoxNoWali.Text = "Nomor Orang Tua/Wali";
            this.textBoxNoWali.Click += new System.EventHandler(this.textBoxNoWali_Click);
            this.textBoxNoWali.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNoWali_KeyPress);
            // 
            // radioButtonLaki
            // 
            this.radioButtonLaki.AutoSize = true;
            this.radioButtonLaki.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonLaki.Location = new System.Drawing.Point(624, 488);
            this.radioButtonLaki.Name = "radioButtonLaki";
            this.radioButtonLaki.Size = new System.Drawing.Size(64, 17);
            this.radioButtonLaki.TabIndex = 5;
            this.radioButtonLaki.TabStop = true;
            this.radioButtonLaki.Text = "Laki-laki";
            this.radioButtonLaki.UseVisualStyleBackColor = false;
            this.radioButtonLaki.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonWanita
            // 
            this.radioButtonWanita.AutoSize = true;
            this.radioButtonWanita.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonWanita.Location = new System.Drawing.Point(744, 488);
            this.radioButtonWanita.Name = "radioButtonWanita";
            this.radioButtonWanita.Size = new System.Drawing.Size(79, 17);
            this.radioButtonWanita.TabIndex = 6;
            this.radioButtonWanita.TabStop = true;
            this.radioButtonWanita.Text = "Perempuan";
            this.radioButtonWanita.UseVisualStyleBackColor = false;
            // 
            // buttonKonfirmasi
            // 
            this.buttonKonfirmasi.Location = new System.Drawing.Point(752, 528);
            this.buttonKonfirmasi.Name = "buttonKonfirmasi";
            this.buttonKonfirmasi.Size = new System.Drawing.Size(75, 32);
            this.buttonKonfirmasi.TabIndex = 7;
            this.buttonKonfirmasi.Text = "Konfirmasi";
            this.buttonKonfirmasi.UseVisualStyleBackColor = true;
            this.buttonKonfirmasi.Click += new System.EventHandler(this.buttonKonfirmasi_Click);
            // 
            // buttonBatal
            // 
            this.buttonBatal.Location = new System.Drawing.Point(616, 528);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(75, 32);
            this.buttonBatal.TabIndex = 8;
            this.buttonBatal.Text = "Batal";
            this.buttonBatal.UseVisualStyleBackColor = true;
            this.buttonBatal.Click += new System.EventHandler(this.buttonBatal_Click);
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlamat.ForeColor = System.Drawing.Color.Gray;
            this.textBoxAlamat.Location = new System.Drawing.Point(616, 280);
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(208, 26);
            this.textBoxAlamat.TabIndex = 9;
            this.textBoxAlamat.TabStop = false;
            this.textBoxAlamat.Text = "Alamat";
            this.textBoxAlamat.Click += new System.EventHandler(this.textBoxAlamat_Click);
            // 
            // dateTimePickerTanggalLahir
            // 
            this.dateTimePickerTanggalLahir.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTanggalLahir.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerTanggalLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTanggalLahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTanggalLahir.Location = new System.Drawing.Point(616, 232);
            this.dateTimePickerTanggalLahir.Name = "dateTimePickerTanggalLahir";
            this.dateTimePickerTanggalLahir.Size = new System.Drawing.Size(208, 26);
            this.dateTimePickerTanggalLahir.TabIndex = 10;
            this.dateTimePickerTanggalLahir.Value = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(616, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tanggal Lahir";
            // 
            // textBoxNamaSekolah
            // 
            this.textBoxNamaSekolah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNamaSekolah.ForeColor = System.Drawing.Color.Gray;
            this.textBoxNamaSekolah.Location = new System.Drawing.Point(616, 432);
            this.textBoxNamaSekolah.Name = "textBoxNamaSekolah";
            this.textBoxNamaSekolah.ReadOnly = true;
            this.textBoxNamaSekolah.Size = new System.Drawing.Size(208, 26);
            this.textBoxNamaSekolah.TabIndex = 12;
            this.textBoxNamaSekolah.TabStop = false;
            this.textBoxNamaSekolah.Text = "SDN BANTULIANS 01";
            this.textBoxNamaSekolah.Click += new System.EventHandler(this.textBoxNamaSekolah_Click);
            // 
            // Daftar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 661);
            this.Controls.Add(this.textBoxNamaSekolah);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerTanggalLahir);
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.buttonKonfirmasi);
            this.Controls.Add(this.radioButtonWanita);
            this.Controls.Add(this.radioButtonLaki);
            this.Controls.Add(this.textBoxNoWali);
            this.Controls.Add(this.textBoxWali);
            this.Controls.Add(this.textBoxNISN);
            this.Controls.Add(this.textBoxNama);
            this.Name = "Daftar";
            this.Text = "Daftar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxNISN;
        private System.Windows.Forms.TextBox textBoxWali;
        private System.Windows.Forms.TextBox textBoxNoWali;
        private System.Windows.Forms.RadioButton radioButtonLaki;
        private System.Windows.Forms.RadioButton radioButtonWanita;
        private System.Windows.Forms.Button buttonKonfirmasi;
        private System.Windows.Forms.Button buttonBatal;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggalLahir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNamaSekolah;
    }
}