using Final_Project.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
