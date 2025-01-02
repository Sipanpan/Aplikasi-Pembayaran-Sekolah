using Final_Project.View;
using Guna.UI2.AnimatorNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class mainForm : Form
    {
        login lgn;
        FormPembayaran pembayaran;
        FormTambahPembayaran tambahPembayaran;
        popUpEditPembayaran popUpEditPembayaran;
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            pnMDI.Visible = false;
            lgn = new login();
            lgn.FormClosed += lgn_FormClosed;
            lgn.MdiParent = this;
            lgn.Dock = DockStyle.Fill;
            lgn.Show();
        }

        private void lgn_FormClosed(object sender, FormClosedEventArgs e)
        {
            lgn = null;
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPembayaran_Click_1(object sender, EventArgs e)
        {
            pnMDI.Visible = false;
            pembayaran = new FormPembayaran();
            pembayaran.FormClosed += pembayaran_FormClosed;
            pembayaran.MdiParent = this;
            pembayaran.Dock = DockStyle.Fill;
            pembayaran.Show();
        }

        private void pembayaran_FormClosed(object sender, FormClosedEventArgs e)
        {
            pembayaran = null;
        }

        private void btnTambahPembayaran_Click(object sender, EventArgs e)
        {
            pnMDI.Visible = false;
            tambahPembayaran = new FormTambahPembayaran();
            tambahPembayaran.FormClosed += tambahPembayaran_FormClosed;
            tambahPembayaran.MdiParent = this;
            tambahPembayaran.Dock = DockStyle.Fill;
            tambahPembayaran.Show();
        }

        private void tambahPembayaran_FormClosed(object sender, FormClosedEventArgs e)
        {
            tambahPembayaran = null;
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            pnMDI.Visible = true;
        }

        private void btnTes_Click(object sender, EventArgs e)
        {
            // membuat objek connection
            SQLiteConnection conn = GetOpenConnection();

            // cek status koneksi
            if (conn != null && conn.State == ConnectionState.Open) // koneksi berhasil
            {
                MessageBox.Show("Koneksi ke database berhasil !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Koneksi ke database gagal !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            conn?.Dispose(); // tutup dan hapus objek connection dari memory
        }

        private SQLiteConnection GetOpenConnection()
        {
            SQLiteConnection conn = null; // deklarasi objek connection

            try // penggunaan blok try-catch untuk penanganan error
            {
                // Lokasi file database relatif terhadap folder aplikasi
                string dbName = @"DbSepatu.db"; // Nama file database
                string basePath = AppDomain.CurrentDomain.BaseDirectory; // Lokasi aplikasi berjalan
                string fullPath = Path.Combine(basePath, dbName); // Gabungkan jalur relatif

                // Buat database jika belum ada
                CreateDatabaseIfNotExists(fullPath);

                // Deklarasi variabel connectionString
                string connectionString = $"Data Source={fullPath};Version=3;FailIfMissing=True";

                // Buat objek connection
                conn = new SQLiteConnection(connectionString);
                conn.Open(); // Buka koneksi ke database
            }
            // jika terjadi error di blok try, akan ditangani langsung oleh blok catch
            catch (Exception ex)
            {
                // Tampilkan pesan error jika terjadi kesalahan
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }

        private void CreateDatabaseIfNotExists(string fullPath)
        {
            try
            {
                if (!File.Exists(fullPath))
                {
                    // Buat file database baru jika belum ada
                    SQLiteConnection.CreateFile(fullPath);
                    MessageBox.Show($"Database baru dibuat di: {fullPath}", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal membuat database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
