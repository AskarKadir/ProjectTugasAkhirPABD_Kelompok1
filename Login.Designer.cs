
namespace UASKELOMPOK
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelDaftar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputEmail
            // 
            this.inputEmail.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputEmail.ForeColor = System.Drawing.Color.Silver;
            this.inputEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.inputEmail.Location = new System.Drawing.Point(660, 340);
            this.inputEmail.MaxLength = 19;
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(260, 32);
            this.inputEmail.TabIndex = 0;
            this.inputEmail.TabStop = false;
            this.inputEmail.Text = "NIS/NIP";
            this.inputEmail.Click += new System.EventHandler(this.inputEmail_Click);
            this.inputEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputEmail_KeyPress);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(750, 400);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(80, 30);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelDaftar
            // 
            this.labelDaftar.AutoSize = true;
            this.labelDaftar.BackColor = System.Drawing.Color.Transparent;
            this.labelDaftar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDaftar.Location = new System.Drawing.Point(820, 475);
            this.labelDaftar.Name = "labelDaftar";
            this.labelDaftar.Size = new System.Drawing.Size(81, 16);
            this.labelDaftar.TabIndex = 1;
            this.labelDaftar.Text = "Daftar disini!";
            this.labelDaftar.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 723);
            this.Controls.Add(this.labelDaftar);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.inputEmail);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelDaftar;
    }
}

