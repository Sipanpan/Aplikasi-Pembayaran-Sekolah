using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project.Model.Entity;
using Final_Project.Model.Repository;
using Final_Project.Model.Context;
using System.Web.Management;


namespace Final_Project.Controller
{
    public class PembayaranController
    {
        // deklarasi objek repository untuk menjalankan operasi CRUD
        private PembayaranRepository _repository;

        public int Create(Pembayaran byr)
        {
            int result = 0;

            // cek kk_pembayaran yan diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(byr.Kd_Pembayaran))
            {
                MessageBox.Show("Kd_Pembayaran harus diisi !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek Nama yan diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(byr.Nama))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek Jumlah yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(byr.Jenis_Pembayaran))
            {
                MessageBox.Show("Jumlah harus diisi !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek Harga yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(byr.Metode_Pembayaran))
            {
                MessageBox.Show("Harga harus diisi !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new PembayaranRepository(context);

                // panggil method Create repository untuk menambahkan data
                result = _repository.Create(byr);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Pembayaran berhasil disimpan !", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Pembayaran gagal disimpan !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public int Update(Pembayaran byr)
        {
            int result = 0;

            // cek Nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(byr.Kd_Pembayaran))
            {
                MessageBox.Show("Kd_Pembayaran harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek Nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(byr.Nama))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek Jumlah yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(byr.Jenis_Pembayaran))
            {
                MessageBox.Show("Jumlah harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek angkatan yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(byr.Metode_Pembayaran))
            {
                MessageBox.Show("Harga harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PembayaranRepository(context);

                // panggil method Update class repository untuk mengupdate data
                result = _repository.Update(byr);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Pembayaran berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Pembayaran gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            return result;
        }

        public int Delete(Pembayaran byr)
        {
            int result = 0;

            // cek nilai Nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(byr.Kd_Pembayaran))
            {
                MessageBox.Show("Kd_Pembayaran harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nilai Nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(byr.Nama))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PembayaranRepository(context);

                // panggil method Delete class repository untuk menghapus data
                result = _repository.Delete(byr);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Pembayaran berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Pembayaran gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public List<Pembayaran> ReadByNama(string Nama)
        {
            // membuat objek collection
            List<Pembayaran> list = new List<Pembayaran>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PembayaranRepository(context);

                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.ReadByNama(Nama);
            }
            return list;
        }

        public List<Pembayaran> ReadAll()
        {
            // membuat objek collection
            List<Pembayaran> list = new List<Pembayaran>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PembayaranRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }
            return list;
        }

        public decimal GetTotal()
        {
            decimal result = 0;

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PembayaranRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                // list = _repository.ReadTTL();
                //result = _repository.GetTotal();
            }
            return result;
        }
    }
}
