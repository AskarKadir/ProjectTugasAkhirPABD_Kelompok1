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
    public partial class Daftar : Form
    {
        public Daftar()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"C:\Users\Asus\OneDrive - Universitas Muhammadiyah Yogyakarta\TUGAS KULIAH\SEMESTER 4\Pengembangan Aplikasi Basis Data\TUGAS AKHIR\UASKELOMPOK\Resources\Registration Page.jpg");
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLaki.Checked)
            {
                radioButtonWanita.Checked = false;
            }
            else
            {
                radioButtonLaki.Checked = false;
            }
        }

        private void textBoxNoWali_Click(object sender, EventArgs e)
        {

            textBoxNoWali.Clear();
            textBoxNoWali.ForeColor = Color.Black;
        }
        private void textBoxNama_Click(object sender, EventArgs e)
        {
            textBoxNama.Clear();
            textBoxNama.ForeColor = Color.Black;
        }
        private void textBoxNISN_Click(object sender, EventArgs e)
        {
            textBoxNISN.Clear();
            textBoxNISN.ForeColor = Color.Black;
            //if(System.Text.RegularExpressions.Regex.IsMatch(textBoxNISN.Text," ^[0-9]"))
            //{
            //    textBoxNISN.Text = "";
            //}
        }
        private void textBoxWali_Click(object sender, EventArgs e)
        {
            textBoxWali.Clear();
            textBoxWali.ForeColor = Color.Black;
        }
        private void textBoxAlamat_Click(object sender, EventArgs e)
        {
            textBoxAlamat.Clear();
            textBoxAlamat.ForeColor = Color.Black;
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
            //if (buttonBatal.Text == "Kembali")
            //{
            //    //DaftarSiswa(textBoxNISN.Text, textBoxNama.Text, dateTimePickerTanggalLahir.Value, textBoxAlamat.Text, textBoxWali.Text, textBoxNoWali.Text, textBoxNamaSekolah.Text);
            //    string strInsertAccount = $"insert into GetData (NISN,Peran,Nama_Sekolah) values ('{textBoxNISN.Text}','Siswa','{textBoxNamaSekolah.Text}')";
            //    string strKoneksi = "Data Source=ASKAR;Initial Catalog=tugasakhirpart3;User ID=sa;Password=123456;MultipleActiveResultSets=True";
            //    SqlConnection koneksi = new SqlConnection(strKoneksi);
            //    SqlCommand cmdakun = new SqlCommand(strInsertAccount, koneksi);
            //    koneksi.Open();
            //    cmdakun.ExecuteNonQuery();
            //    koneksi.Close();
            //    Login login = new Login();
            //    this.Hide();
            //    login.Show();
            //}
            //else
            //{
            //    Login login = new Login();
            //    this.Hide();
            //    login.Show();
            //}
        }

        private void buttonKonfirmasi_Click(object sender, EventArgs e)
        {
            insertSiswa(textBoxNISN.Text, textBoxNama.Text, dateTimePickerTanggalLahir.Value, textBoxAlamat.Text, textBoxWali.Text, textBoxNoWali.Text, textBoxNamaSekolah.Text);
            insertGetData();
            insertHasilKelulusan();
            insertKelas();
            MessageBox.Show("Silahkan Kembali Untuk Login");
            //DaftarSiswa(textBoxNISN.Text, textBoxNama.Text, dateTimePickerTanggalLahir.Value, textBoxAlamat.Text, textBoxWali.Text, textBoxNoWali.Text, textBoxNamaSekolah.Text);
        }

        //public void DaftarSiswa(string Nama, string NISN, DateTime TanggalLahir, string Alamat, string NamaWali, string NoHPWali, string NamaSekolah)
        //{
        //}

        private void insertSiswa(string Nama, string NISN, DateTime TanggalLahir, string Alamat, string NamaWali, string NoHPWali, string NamaSekolah)
        {
            try
            {
                string newTanggalLahir = TanggalLahir.ToString("yyyy/MM/dd").Replace("/", "-");
                string strInsertAccount = $"exec insertSiswa '{Nama}','{NISN}','{newTanggalLahir}','{Alamat}','{NamaWali}','{NoHPWali}','{NamaSekolah}'";
                string strKoneksi = "Data Source=ASKAR;Initial Catalog=tugasakhirpart3;User ID=sa;Password=123456;MultipleActiveResultSets=True";
                SqlConnection koneksi = new SqlConnection(strKoneksi);
                SqlCommand cmdakun = new SqlCommand(strInsertAccount, koneksi);
                koneksi.Open();
                cmdakun.ExecuteNonQuery();
                koneksi.Close();
            }
            catch
            {
                MessageBox.Show("insertSiswa");
            }
        }

        private void insertKelas() //testing
        {
            try
            {
                //DaftarSiswa(textBoxNISN.Text, textBoxNama.Text, dateTimePickerTanggalLahir.Value, textBoxAlamat.Text, textBoxWali.Text, textBoxNoWali.Text, textBoxNamaSekolah.Text);
                string strInsertAccount = $"insert into Kelas (Nama_Sekolah,NISN) values ('{textBoxNamaSekolah.Text}','{textBoxNISN.Text}')";
                string strKoneksi = "Data Source=ASKAR;Initial Catalog=tugasakhirpart3;User ID=sa;Password=123456;MultipleActiveResultSets=True";
                SqlConnection koneksi = new SqlConnection(strKoneksi);
                SqlCommand cmdakun = new SqlCommand(strInsertAccount, koneksi);
                koneksi.Open();
                cmdakun.ExecuteNonQuery();
                koneksi.Close();
            }
            catch
            {
                MessageBox.Show("insertKelas Error");
            }
        }

        private void insertHasilKelulusan()
        {
            try
            {
                //DaftarSiswa(textBoxNISN.Text, textBoxNama.Text, dateTimePickerTanggalLahir.Value, textBoxAlamat.Text, textBoxWali.Text, textBoxNoWali.Text, textBoxNamaSekolah.Text);
                string strInsertAccount = $"insert into Hasil_Kelulusan (NISN,Nama_Sekolah) values ('{textBoxNISN.Text}','{textBoxNamaSekolah.Text}')";
                string strKoneksi = "Data Source=ASKAR;Initial Catalog=tugasakhirpart3;User ID=sa;Password=123456;MultipleActiveResultSets=True";
                SqlConnection koneksi = new SqlConnection(strKoneksi);
                SqlCommand cmdakun = new SqlCommand(strInsertAccount, koneksi);
                koneksi.Open();
                cmdakun.ExecuteNonQuery();
                koneksi.Close();
            }
            catch
            {
                MessageBox.Show("insertHasilKelulusan");
            }
        }

        private void insertGetData()
        {
            try
            {
                //DaftarSiswa(textBoxNISN.Text, textBoxNama.Text, dateTimePickerTanggalLahir.Value, textBoxAlamat.Text, textBoxWali.Text, textBoxNoWali.Text, textBoxNamaSekolah.Text);
                string strInsertAccount = $"insert into GetData (NISN,Peran,Nama_Sekolah) values ('{textBoxNISN.Text}','Siswa','{textBoxNamaSekolah.Text}')";
                string strKoneksi = "Data Source=ASKAR;Initial Catalog=tugasakhirpart3;User ID=sa;Password=123456;MultipleActiveResultSets=True";
                SqlConnection koneksi = new SqlConnection(strKoneksi);
                SqlCommand cmdakun = new SqlCommand(strInsertAccount, koneksi);
                koneksi.Open();
                cmdakun.ExecuteNonQuery();
                koneksi.Close();
            }
            catch
            {
                MessageBox.Show("InsertGetData");
            }
        }

        private void textBoxNamaSekolah_Click(object sender, EventArgs e)
        {
            textBoxNamaSekolah.Clear();
            textBoxNamaSekolah.ForeColor = Color.Black;
        }

        private void textBoxNISN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxNoWali_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
