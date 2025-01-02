using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project.Controller;
using Final_Project.Model.Entity;


namespace Final_Project.View
{
    public partial class FormPembayaran : Form
    {
        // deklarasi collection untuk menampung objek barang
        private List<Pembayaran> listOfPembayaran = new List<Pembayaran>();

        // deklarasi objek controller
        private PembayaranController controller;
        public FormPembayaran()
        {
            InitializeComponent();
            // membuat objek controller
            controller = new PembayaranController();
            LoadDataPembayaran();
            InisialisasiListView();
        }

        private void InisialisasiListView()
        {
            lvwPembayaran.View = System.Windows.Forms.View.Details;
            lvwPembayaran.FullRowSelect = true;
            lvwPembayaran.GridLines = true;

            lvwPembayaran.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwPembayaran.Columns.Add("Kode Pembayaran", 100, HorizontalAlignment.Center);
            lvwPembayaran.Columns.Add("Nama", 200, HorizontalAlignment.Left);
            lvwPembayaran.Columns.Add("Jenis Pembayaran", 200, HorizontalAlignment.Center);
            lvwPembayaran.Columns.Add("Jenis Pembayaran", 200, HorizontalAlignment.Center);
            lvwPembayaran.Columns.Add("Total", 100, HorizontalAlignment.Center);
        }

        // method untuk menampilkan semua data mahasiswa
        private void LoadDataPembayaran()
        {
            // kosongkan listview
            lvwPembayaran.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfPembayaran = controller.ReadAll();
            //txtTotal.Text = controller.GetTotal().ToString();

            // ekstrak objek brg dari collection
            foreach (var byr in listOfPembayaran)
            {
                var noUrut = lvwPembayaran.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(byr.Kd_Pembayaran);
                item.SubItems.Add(byr.Nama);
                item.SubItems.Add(byr.Jenis_Pembayaran);
                item.SubItems.Add(byr.Metode_Pembayaran);
                item.SubItems.Add(byr.Total.ToString());

                // tampilkan data brg ke listview
                lvwPembayaran.Items.Add(item);
            }
        }

        // method event handler untuk merespon event OnCreate
        private void OnCreateEventHandler(Pembayaran byr)
        {
            // tambahkan objek brg yang baru ke dalam collection
            listOfPembayaran.Add(byr);

            int noUrut = lvwPembayaran.Items.Count + 1;

            // tampilkan data brg yang baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(byr.Kd_Pembayaran);
            item.SubItems.Add(byr.Nama);
            item.SubItems.Add(byr.Jenis_Pembayaran);
            item.SubItems.Add(byr.Metode_Pembayaran);
            item.SubItems.Add(byr.Total.ToString());

            lvwPembayaran.Items.Add(item);
        }

        // method event handler untuk merespon even onUpdate
        private void OnUpdateEventHandler(Pembayaran byr)
        {
            // ambil index data brg yang edit
            int index = lvwPembayaran.SelectedIndices[0];

            // update informasi brg di listview
            ListViewItem itemRow = lvwPembayaran.Items[index];
            itemRow.SubItems[2].Text = byr.Kd_Pembayaran;
            itemRow.SubItems[1].Text = byr.Nama;
            itemRow.SubItems[2].Text = byr.Jenis_Pembayaran;
            itemRow.SubItems[3].Text = byr.Metode_Pembayaran;
            itemRow.SubItems[4].Text = byr.Total.ToString();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPerbaiki_Click(object sender, EventArgs e)
        {
            if (lvwPembayaran.SelectedItems.Count > 0)
            {
                // ambil objek brg yang mau diedit dari collection
                Pembayaran byr = listOfPembayaran[lvwPembayaran.SelectedIndices[0]];

                // buat objek form entry data barang
                //formTambah frmTambah = new formTambah("Perbaiki Data Pembayaran", byr, controller); !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                // mendaftarkan method event handler untuk merespon event OnUpdate
                //frmTambah.OnUpdate += OnUpdateEventHandler;

                // tampilkan form tambah
                //frmTambah.ShowDialog();
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data belum dipilih", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lvwPembayaran.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data pembayaran ingin dihapus ?", "Konfirmasi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek brg yang mau dihapus dari collection
                    Pembayaran byr = listOfPembayaran[lvwPembayaran.SelectedIndices[0]];

                    // panggil operasi CRUD
                    var result = controller.Delete(byr);
                    if (result > 0)
                    {
                        LoadDataPembayaran();
                    }
                }

            }
            else // data belum dipilih
            {
                MessageBox.Show("Data pembayaran belum dipilih !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
