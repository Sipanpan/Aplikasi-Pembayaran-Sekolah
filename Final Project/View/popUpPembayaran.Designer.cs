namespace Final_Project.View
{
    partial class popUpEditPembayaran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBayar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnGenerate = new Guna.UI2.WinForms.Guna2Button();
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbxMetodePembayaran = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxJenisBayar = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNamaPembayar = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtKodeBayar = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblJudul = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBayar
            // 
            this.btnBayar.BorderColor = System.Drawing.Color.White;
            this.btnBayar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBayar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBayar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBayar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBayar.FillColor = System.Drawing.Color.Black;
            this.btnBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBayar.ForeColor = System.Drawing.Color.White;
            this.btnBayar.Location = new System.Drawing.Point(25, 571);
            this.btnBayar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(605, 59);
            this.btnBayar.TabIndex = 11;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.btnGenerate);
            this.guna2Panel1.Controls.Add(this.btnBayar);
            this.guna2Panel1.Controls.Add(this.txtTotal);
            this.guna2Panel1.Controls.Add(this.cbxMetodePembayaran);
            this.guna2Panel1.Controls.Add(this.cbxJenisBayar);
            this.guna2Panel1.Controls.Add(this.txtNamaPembayar);
            this.guna2Panel1.Controls.Add(this.txtKodeBayar);
            this.guna2Panel1.Controls.Add(this.lblJudul);
            this.guna2Panel1.Location = new System.Drawing.Point(1, 3);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(651, 662);
            this.guna2Panel1.TabIndex = 2;
            // 
            // btnGenerate
            // 
            this.btnGenerate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(506, 82);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(126, 35);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.Text = "Isi Kode Bayar";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.DefaultText = "";
            this.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.txtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.Location = new System.Drawing.Point(27, 455);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtTotal.PlaceholderText = "";
            this.txtTotal.SelectedText = "";
            this.txtTotal.Size = new System.Drawing.Size(605, 52);
            this.txtTotal.TabIndex = 10;
            // 
            // cbxMetodePembayaran
            // 
            this.cbxMetodePembayaran.BackColor = System.Drawing.Color.Transparent;
            this.cbxMetodePembayaran.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxMetodePembayaran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMetodePembayaran.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.cbxMetodePembayaran.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxMetodePembayaran.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxMetodePembayaran.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxMetodePembayaran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxMetodePembayaran.ItemHeight = 30;
            this.cbxMetodePembayaran.Items.AddRange(new object[] {
            "Tunai",
            "Bank"});
            this.cbxMetodePembayaran.Location = new System.Drawing.Point(339, 340);
            this.cbxMetodePembayaran.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMetodePembayaran.Name = "cbxMetodePembayaran";
            this.cbxMetodePembayaran.Size = new System.Drawing.Size(292, 36);
            this.cbxMetodePembayaran.TabIndex = 8;
            // 
            // cbxJenisBayar
            // 
            this.cbxJenisBayar.BackColor = System.Drawing.Color.Transparent;
            this.cbxJenisBayar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxJenisBayar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxJenisBayar.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.cbxJenisBayar.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxJenisBayar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxJenisBayar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxJenisBayar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxJenisBayar.ItemHeight = 30;
            this.cbxJenisBayar.Items.AddRange(new object[] {
            "SPP",
            "Biaya Ujian",
            "Biaya Pembangunan"});
            this.cbxJenisBayar.Location = new System.Drawing.Point(31, 340);
            this.cbxJenisBayar.Margin = new System.Windows.Forms.Padding(4);
            this.cbxJenisBayar.Name = "cbxJenisBayar";
            this.cbxJenisBayar.Size = new System.Drawing.Size(292, 36);
            this.cbxJenisBayar.TabIndex = 6;
            // 
            // txtNamaPembayar
            // 
            this.txtNamaPembayar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamaPembayar.DefaultText = "";
            this.txtNamaPembayar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNamaPembayar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNamaPembayar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaPembayar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaPembayar.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.txtNamaPembayar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaPembayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNamaPembayar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtNamaPembayar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaPembayar.Location = new System.Drawing.Point(27, 238);
            this.txtNamaPembayar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNamaPembayar.Name = "txtNamaPembayar";
            this.txtNamaPembayar.PasswordChar = '\0';
            this.txtNamaPembayar.PlaceholderText = "";
            this.txtNamaPembayar.SelectedText = "";
            this.txtNamaPembayar.Size = new System.Drawing.Size(605, 52);
            this.txtNamaPembayar.TabIndex = 4;
            // 
            // txtKodeBayar
            // 
            this.txtKodeBayar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKodeBayar.DefaultText = "";
            this.txtKodeBayar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKodeBayar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKodeBayar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKodeBayar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKodeBayar.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.txtKodeBayar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKodeBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtKodeBayar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtKodeBayar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKodeBayar.Location = new System.Drawing.Point(27, 134);
            this.txtKodeBayar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKodeBayar.Name = "txtKodeBayar";
            this.txtKodeBayar.PasswordChar = '\0';
            this.txtKodeBayar.PlaceholderText = "";
            this.txtKodeBayar.SelectedText = "";
            this.txtKodeBayar.Size = new System.Drawing.Size(605, 52);
            this.txtKodeBayar.TabIndex = 2;
            // 
            // lblJudul
            // 
            this.lblJudul.BackColor = System.Drawing.Color.Transparent;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.Color.White;
            this.lblJudul.Location = new System.Drawing.Point(27, 16);
            this.lblJudul.Margin = new System.Windows.Forms.Padding(4);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(186, 31);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Edit Pembayaran";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kode Bayar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nama Pembayar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Jenis Pembayaran";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Metode Pembayaran";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Total";
            // 
            // popUpEditPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(651, 662);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "popUpEditPembayaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "popUpEditPembayaran";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnBayar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtTotal;
        private Guna.UI2.WinForms.Guna2ComboBox cbxMetodePembayaran;
        private Guna.UI2.WinForms.Guna2ComboBox cbxJenisBayar;
        private Guna.UI2.WinForms.Guna2TextBox txtNamaPembayar;
        private Guna.UI2.WinForms.Guna2TextBox txtKodeBayar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblJudul;
        private Guna.UI2.WinForms.Guna2Button btnGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}