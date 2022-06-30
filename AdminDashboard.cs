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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"C:\Users\Asus\OneDrive - Universitas Muhammadiyah Yogyakarta\TUGAS KULIAH\SEMESTER 4\Pengembangan Aplikasi Basis Data\TUGAS AKHIR\UASKELOMPOK\Resources\Data Siswa.jpg");
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tugasakhirpart3DataSet3.tampilanAdmin' table. You can move, or remove it, as needed.
            //this.tampilanAdminTableAdapter2.Fill(this.tugasakhirpart3DataSet3.tampilanAdmin);
            // TODO: This line of code loads data into the 'tugasakhirpart3DataSet2.tampilanAdmin' table. You can move, or remove it, as needed.
            //this.tampilanAdminTableAdapter1.Fill(this.tugasakhirpart3DataSet2.tampilanAdmin);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridViewAdmin.Rows[index];
            textBoxNamaSiswaAdmin.Text = selectedRow.Cells[0].Value.ToString();
            textBoxNISNAdmin.Text = selectedRow.Cells[1].Value.ToString();
            textBoxTanggalLahir.Text = selectedRow.Cells[2].Value.ToString();
            textBoxTingkatanKelas.Text = selectedRow.Cells[3].Value.ToString();
            textBoxWali.Text = selectedRow.Cells[4].Value.ToString();
            textBoxHasil.Text = selectedRow.Cells[5].Value.ToString();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string strKoneksi = "Data Source=ASKAR;Initial Catalog=tugasakhirpart3;User ID=sa;Password=123456";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from tampilanAdmin where Nama_Siswa like '%{textBoxPencarian.Text}%' or NISN='{textBoxPencarian.Text}'";
            cmd.ExecuteNonQuery();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dt.Clear();
            try
            {
                sqlDataAdapter.Fill(dt);
                dataGridViewAdmin.DataSource = dt;
                MessageBox.Show("Hasil Pencarian Paling Mendekati");

            }
            catch (Exception er)
            {
                Console.WriteLine("Error : " + er);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            string strKoneksi = "Data Source=ASKAR;Initial Catalog=tugasakhirpart3;User ID=sa;Password=123456";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tampilanAdmin";
            cmd.ExecuteNonQuery();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dt.Clear();
            try
            {
                sqlDataAdapter.Fill(dt);
                dataGridViewAdmin.DataSource = dt;
            }
            catch (Exception er)
            {
                Console.WriteLine("Error : " + er);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            deleteHasilKelulusan();
            deleteGetData();
            delteSiswa();
            deleteKelas();
        }

        private void deleteKelas()
        {
            try
            {
                string strKoneksi = "Data Source=ASKAR;Initial Catalog=tugasakhirpart3;User ID=sa;Password=123456";
                SqlConnection koneksi = new SqlConnection();
                koneksi.ConnectionString = strKoneksi;
                koneksi.Open();
                SqlCommand cmd = koneksi.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"delete from Kelas where NISN='{textBoxNISNAdmin.Text}'";
                cmd.ExecuteNonQuery();
                koneksi.Close();
            }
            catch
            {
                MessageBox.Show("Eror");
            }
        }

        private void delteSiswa()
        {
            try
            {
                string strKoneksi = "Data Source=ASKAR;Initial Catalog=tugasakhirpart3;User ID=sa;Password=123456";
                SqlConnection koneksi = new SqlConnection();
                koneksi.ConnectionString = strKoneksi;
                koneksi.Open();
                SqlCommand cmd = koneksi.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"delete from Siswa where NISN='{textBoxNISNAdmin.Text}'";
                cmd.ExecuteNonQuery();
                koneksi.Close();
            }
            catch
            {
                MessageBox.Show("Eror");
            }
        }

        private void deleteGetData()
        {
            try
            {
                string strKoneksi = "Data Source=ASKAR;Initial Catalog=tugasakhirpart3;User ID=sa;Password=123456";
                SqlConnection koneksi = new SqlConnection();
                koneksi.ConnectionString = strKoneksi;
                koneksi.Open();
                SqlCommand cmd = koneksi.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"delete from GetData where NISN='{textBoxNISNAdmin.Text}'";
                cmd.ExecuteNonQuery();
                koneksi.Close();
            }
            catch
            {
                MessageBox.Show("Eror");
            }
        }

        private void deleteHasilKelulusan()
        {
            try
            {
                string strKoneksi = "Data Source=ASKAR;Initial Catalog=tugasakhirpart3;User ID=sa;Password=123456";
                SqlConnection koneksi = new SqlConnection();
                koneksi.ConnectionString = strKoneksi;
                koneksi.Open();
                SqlCommand cmd = koneksi.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"delete from Hasil_Kelulusan where NISN='{textBoxNISNAdmin.Text}'";
                cmd.ExecuteNonQuery();
                koneksi.Close();
            }
            catch
            {
                MessageBox.Show("Eror");
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            simpanKelas();
            simpanWaliKelas();
            simpanHasilSiswa();
        }

        private void simpanHasilSiswa()
        {
            try
            {
                string strKoneksi = "Data Source=ASKAR;Initial Catalog=tugasakhirpart3;User ID=sa;Password=123456";
                SqlConnection koneksi = new SqlConnection();
                koneksi.ConnectionString = strKoneksi;
                koneksi.Open();
                SqlCommand cmd = koneksi.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"update Hasil_Kelulusan SET Hasil_Siswa = '{textBoxHasil.Text}' where NISN='{textBoxNISNAdmin.Text}'";
                cmd.ExecuteNonQuery();
                koneksi.Close();
            }
            catch
            {
                MessageBox.Show("Eror");
            }
        }

        private void simpanWaliKelas()
        {
            try
            {
                string strKoneksi = "Data Source=ASKAR;Initial Catalog=tugasakhirpart3;User ID=sa;Password=123456";
                SqlConnection koneksi = new SqlConnection();
                koneksi.ConnectionString = strKoneksi;
                koneksi.Open();
                SqlCommand cmd = koneksi.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"update Kelas SET Wali_Kelas = '{textBoxWali.Text}' where NISN='{textBoxNISNAdmin.Text}'";
                cmd.ExecuteNonQuery();
                koneksi.Close();
            }
            catch
            {
                MessageBox.Show("Eror");
            }
        }

        private void simpanKelas()
        {
            try
            {
                string strKoneksi = "Data Source=ASKAR;Initial Catalog=tugasakhirpart3;User ID=sa;Password=123456";
                SqlConnection koneksi = new SqlConnection();
                koneksi.ConnectionString = strKoneksi;
                koneksi.Open();
                SqlCommand cmd = koneksi.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"update Kelas SET Tingkatan_Kelas = '{textBoxTingkatanKelas.Text}' where NISN='{textBoxNISNAdmin.Text}'";
                cmd.ExecuteNonQuery();
                koneksi.Close();
            }
            catch
            {
                MessageBox.Show("Eror");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
