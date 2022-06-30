using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UASKELOMPOK
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"C:\Users\Asus\OneDrive - Universitas Muhammadiyah Yogyakarta\TUGAS KULIAH\SEMESTER 4\Pengembangan Aplikasi Basis Data\TUGAS AKHIR\UASKELOMPOK\Resources\Login Page.jpg");
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //mengambil data akun (email/username dan password) dari database
            if(inputEmail.TextLength == 19)
            {
                string strInputcommand = $"select NIP,Peran from GetData where NIP='{inputEmail.Text}'";
                string strKoneksi = "Data Source=ASKAR;Initial Catalog=tugasakhirpart3;User ID=sa;Password=123456";
                SqlConnection koneksi = new SqlConnection();
                koneksi.ConnectionString = strKoneksi;
                koneksi.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(strInputcommand,koneksi);
                    //cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    MessageBox.Show("Masuk sebagai Admin");
                    koneksi.Close();
                    this.Hide();
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();

                }
                catch(Exception er)
                {
                    Console.WriteLine("Error : " + er);
                }
            }
            else if(inputEmail.TextLength == 8)
            {
                string strInputcommand = $"select a.NISN,a.Peran,b.Hasil_Siswa from GetData a join Hasil_Kelulusan b on a.NISN = b.NISN where a.NISN = '{inputEmail.Text}'";
                string strKoneksi = "Data Source=ASKAR;Initial Catalog=tugasakhirpart3;User ID=sa;Password=123456";
                SqlConnection koneksi = new SqlConnection();
                koneksi.ConnectionString = strKoneksi;
                koneksi.Open();
                SqlCommand cmd = new SqlCommand(strInputcommand,koneksi);
                //cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                try
                {
                    if(reader[2].ToString() == "Lulus")
                    {
                        SiswaDashboard siswaDashboard = new SiswaDashboard();
                        this.Hide();
                        siswaDashboard.Show();
                    }
                    else if(reader[2].ToString() == "Tidak Lulus")
                    {
                        GagalSiswa gagalSiswa = new GagalSiswa();
                        this.Hide();
                        gagalSiswa.Show();
                    }
                    else
                    {
                        NungguPengumuman nungguPengumuman = new NungguPengumuman();
                        this.Hide();
                        nungguPengumuman.Show();
                    }
                }
                catch(Exception er)
                {
                    Console.WriteLine("Error : " + er);
                }
            }
            else
            {
                MessageBox.Show("Akun tidak terdaftar");
            }

        }

        private void inputEmail_Click(object sender, EventArgs e)
        {
            inputEmail.Clear();
            inputEmail.ForeColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //open new form
            Daftar daftar = new Daftar();
            this.Hide();
            daftar.Show();
        }

        private void inputEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
