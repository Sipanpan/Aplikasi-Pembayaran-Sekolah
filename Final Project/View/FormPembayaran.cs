using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.View
{
    public partial class FormPembayaran : Form
    {
        public FormPembayaran()
        {
            InitializeComponent();
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
    }
}
