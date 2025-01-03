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
using Final_Project.Controller;
using Final_Project.Model.Entity;

namespace Final_Project
{
    public partial class mainForm : Form
    {
        login lgn;
        FormPembayaran pembayaran;
        FormTambahPembayaran tambahPembayaran;
        popUpEditPembayaran popUpEditPembayaran;
        keluar keluar;
        about about;

        // deklarasi collection untuk menampung objek barang
        private List<Pembayaran> listOfPembayaran = new List<Pembayaran>();

        // deklarasi objek controller
        private PembayaranController controller;


        public mainForm()
        {
            InitializeComponent();
            // membuat objek controller
            controller = new PembayaranController();
        }


        // method event handler untuk merespon event OnCreate
        private void OnCreateEventHandler(Pembayaran byr)
        {
            // tambahkan objek brg yang baru ke dalam collection
            listOfPembayaran.Add(byr);

            int noUrut = listOfPembayaran.Count + 1;

            // tampilkan data brg yang baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(byr.Kd_Pembayaran);
            item.SubItems.Add(byr.Nama);
            item.SubItems.Add(byr.Jenis_Pembayaran);
            item.SubItems.Add(byr.Metode_Pembayaran);
            item.SubItems.Add(byr.Total.ToString());

            // lvwBarang.Items.Add(item);
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
            pnMDI.Visible = false;
            keluar = new keluar();
            keluar.FormClosed += keluar_FormClosed;
            keluar.MdiParent = this;
            keluar.Dock = DockStyle.Fill;
            keluar.Show();
        }

        private void keluar_FormClosed(object sender, FormClosedEventArgs e)
        {
            keluar = null;
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
            // buat objek form entry data barang
            popUpEditPembayaran frmpop = new popUpEditPembayaran("Tambah Pembayaran", controller, "Bakso Jumbo");

            // mendaftarkan method event handler utk merespon event OnCreate (subscribe)
            frmpop.OnCreate += OnCreateEventHandler;

            // tampilkan form entry barang
            frmpop.ShowDialog();

            /*pnMDI.Visible = false;
            tambahPembayaran = new FormTambahPembayaran();
            tambahPembayaran.FormClosed += tambahPembayaran_FormClosed;
            tambahPembayaran.MdiParent = this;
            tambahPembayaran.Dock = DockStyle.Fill;
            tambahPembayaran.Show();*/
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            pnMDI.Visible = false;
            about = new about();
            about.FormClosed += about_FormClosed;
            about.MdiParent = this;
            about.Dock = DockStyle.Fill;
            about.Show();
        }

        private void about_FormClosed(object sender, FormClosedEventArgs e)
        {
            about = null;
        }
    }
}
