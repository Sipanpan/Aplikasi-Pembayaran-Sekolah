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
            LoadDataMahasiswa();
            InisialisasiListView();
        }

        private void InisialisasiListView()
        {
            lvwPembayaran.View = System.Windows.Forms.View.Details;
            lvwPembayaran.FullRowSelect = true;
            lvwPembayaran.GridLines = true;

            lvwPembayaran.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwPembayaran.Columns.Add("Kode Pembayaran", 100, HorizontalAlignment.Center);
            lvwPembayaran.Columns.Add("Nama", 400, HorizontalAlignment.Left);
            lvwPembayaran.Columns.Add("Jenis Pembayaran", 100, HorizontalAlignment.Center);
            lvwPembayaran.Columns.Add("Total", 200, HorizontalAlignment.Center);
        }

        // method untuk menampilkan semua data mahasiswa
        private void LoadDataMahasiswa()
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
    }
}
