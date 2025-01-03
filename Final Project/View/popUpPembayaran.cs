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
    // deklarasi tipe data untuk event OnCreate dan OnUpdate
    public delegate void CreateUpdateEventHandler(Pembayaran byr);

    public partial class popUpEditPembayaran : Form
    {
        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;

        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;

        // deklarasi objek controller
        private PembayaranController Controller;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        // deklarasi field untuk meyimpan objek barang
        private Pembayaran byr;

        public popUpEditPembayaran()
        {
            InitializeComponent();
        }

        // Constructor untuk inisialisasi data ketika entri data baru
        public popUpEditPembayaran(string title, PembayaranController controller, string nama) : this()
        {
            lblJudul.Text = title;
            // ganti text/judul form
            this.Text = title;
            this.Controller = controller;

            Pembayaran byr = new Pembayaran();

            byr.Nama = nama;
            //byr.Harga = harga;
        }

        // Constructor untuk inisialisasi data ketika mengedit data
        public popUpEditPembayaran(string title, Pembayaran obj, PembayaranController controller) : this()
        {
            txtKodeBayar.ReadOnly = true;
            // ganti text/judul form
            this.Text = title;
            this.Controller = controller;

            isNewData = false; // set status edit data
            byr = obj; // set objek brg yang akan diedit

            // untuk edit data, tampilkan data lama
            lblJudul.Text = title;
            txtKodeBayar.Text = byr.Kd_Pembayaran;
            txtNamaPembayar.Text = byr.Nama;
            cbxJenisBayar.Text = byr.Jenis_Pembayaran;
            cbxMetodePembayaran.Text = byr.Metode_Pembayaran;
            txtTotal.Text = byr.Total.ToString();
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            // jika data baru, inisisalisasi objek barang
            if (isNewData) byr = new Pembayaran();

            // set nilai property objek barang yang diambil dari textbox
            byr.Kd_Pembayaran = txtKodeBayar.Text;
            byr.Nama = txtNamaPembayar.Text;
            byr.Jenis_Pembayaran = cbxJenisBayar.Text;
            byr.Metode_Pembayaran = cbxMetodePembayaran.Text;
            byr.Total = Convert.ToInt32(txtTotal.Text);

            int result = 0;

            if (isNewData) // tambah data baru, panggil method create
            {
                // panggil operasi CRUD
                result = Controller.Create(byr);

                if (result > 0) // tambah data berhasil
                {
                    OnCreate(byr); // panggil event OnCreate

                    // reset form input, untuk persiapan input data berikutnya
                    txtKodeBayar.Clear();
                    this.Close();
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = Controller.Update(byr);
                txtKodeBayar.ReadOnly = false;

                if (result > 0)
                {
                    OnUpdate(byr); // panggil event OnUpdate
                    this.Close();
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateKd();

        }

        private void GenerateKd()
        {
           // txtKodeBayar = byr.Kd_Pembayaran;
        }
    }
}
