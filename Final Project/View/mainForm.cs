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
        FormBeranda dashboard;
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnMDI.Visible = false;
            dashboard = new FormBeranda();
            dashboard.FormClosed += dashboard_FormClosed;
            dashboard.MdiParent = this;
            dashboard.Dock = DockStyle.Fill;
            dashboard.Show();
        }

        private void dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
