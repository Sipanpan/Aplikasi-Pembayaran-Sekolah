using Final_Project.Model.Entity;
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
using Guna.UI2.AnimatorNS;

namespace Final_Project.View
{
    // deklarasi tipe data untuk event OnCreate dan OnUpdate
    //public delegate void CreateUpdateEventHandler(Pembayaran byr);

    public partial class FormTambahPembayaran : Form
    {
        // deklarasi collection untuk menampung objek barang
        private List<Pembayaran> listOfPembayaran = new List<Pembayaran>();

        // deklarasi objek controller
        private PembayaranController controller;

        public FormTambahPembayaran()
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

        private void FormTambahPembayaran_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //string ww = "Bakso Jumbo";

            // buat objek form entry data barang
            popUpEditPembayaran frmpop = new popUpEditPembayaran("Tambah Pembayaran", controller, "Bakso Jumbo");

            // mendaftarkan method event handler utk merespon event OnCreate (subscribe)
            frmpop.OnCreate += OnCreateEventHandler;

            // tampilkan form entry barang
            frmpop.ShowDialog();
        }


        /*// deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;

        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;

        // deklarasi objek controller
        private PembayaranController controller;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        // deklarasi field untuk meyimpan objek barang
        private Pembayaran byr;
        public FormTambahPembayaran()
        {
            InitializeComponent();

            // membuat objek controller
            controller = new PembayaranController();
        }

        // Constructor untuk inisialisasi data ketika entri data baru
        public FormTambahPembayaran(string title, PembayaranController controller, string nama) : this()
        {
            //lblJudul.Text = nama;
            //lblHarga.Text = harga;
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;

           // Barang brg = new Barang();

          //  brg.Nama = nama;
           // brg.Harga = harga;
        }

        // Constructor untuk inisialisasi data ketika entri data baru
        public FormTambahPembayaran(PembayaranController controller, string nama) : this()
        {
            //lblJudul.Text = nama;
            //lblHarga.Text = harga;
            // ganti text/judul form
            //this.Text = title;
            this.Controller = controller;

            Pembayaran byr = new Pembayaran();

            byr.Nama = nama;
            //byr.Kd_Pembayaran = harga;
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            // jika data baru, inisisalisasi objek barang
            Pembayaran byr = new Pembayaran();

            // set nilai property objek barang yang diambil dari textbox
            byr.Kd_Pembayaran = txtKodeBayar.Text;
            byr.Nama = txtNamaPembayar.Text;
            byr.Jenis_Pembayaran = cbxJenisBayar.Text;
            byr.Metode_Pembayaran = cbxMetodePembayaran.Text;
            byr.Total = Convert.ToInt32(txtTotal.Text);

            int result = 0;

            // panggil operasi CRUD
            //result = Controller.Create(byr);

            if (isNewData) // tambah data baru, panggil method create
            {
                // panggil operasi CRUD
                result = controller.Create(byr);

                if (result > 0) // tambah data berhasil
                {
                    OnCreate(byr); // panggil event OnCreate

                    // reset form input, untuk persiapan input data berikutnya
                    txtKodeBayar.Clear();
                    txtNamaPembayar.Clear();
                    txtTotal.Clear();
                    cbxJenisBayar.Items.Clear();
                    cbxMetodePembayaran.Items.Clear();
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = Controller.Update(byr);

                if (result > 0)
                {
                    OnUpdate(byr); // panggil event OnUpdate
                    this.Close();
                }
            }

            /*if (result > 0) // tambah data berhasil
            {
                OnCreate(byr); // panggil event OnCreate

                // reset form input, untuk persiapan input data berikutnya
                txtKodeBayar.Clear();
                txtNamaPembayar.Clear();
                txtTotal.Clear();
                cbxJenisBayar.Items.Clear();
                cbxMetodePembayaran.Items.Clear();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //string ww = "Bakso Jumbo";

            // buat objek form entry data barang
            popUpEditPembayaran frmpop = new popUpEditPembayaran("Tambah Data Barang", controller, "Bakso Jumbo", "17000");

            // mendaftarkan method event handler utk merespon event OnCreate (subscribe)
            frmTambah.OnCreate += OnCreateEventHandler;

            // tampilkan form entry barang
            frmTambah.ShowDialog();
        }*/
    }
}
