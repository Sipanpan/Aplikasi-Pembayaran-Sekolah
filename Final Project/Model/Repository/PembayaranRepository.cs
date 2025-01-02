using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Final_Project.Model.Entity;
using Final_Project.Model.Context;
using System.Threading;
using System.Data.SqlClient;


namespace Final_Project.Model.Repository
{
    public class PembayaranRepository
    {
        // deklarasi objek connection
        private SQLiteConnection _conn;

        // constructor
        public PembayaranRepository(DbContext context)
        {
            // inisialisasi objek connection
            _conn = context.Conn;
        }

        public int Create(Pembayaran byr)
        {
            int result = 0;

            // deklarasi perintah sql
            string sql = @"insert into pembayaran (Kd_Pembayaran, Nama, Jenis_Pembayaran, Metode_Pembayaran, Total)
                            values (@Kd_pembayaran, @Nama, @Jenis_Pembayaran, @Metode_Pembayaran, @Total)";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@Kd_Pembayaran", byr.kd_Pembayaran);
                cmd.Parameters.AddWithValue("@Nama", byr.Nama);
                cmd.Parameters.AddWithValue("@Jenis_Pembayaran", byr.Jenis_Pembayaran);
                cmd.Parameters.AddWithValue("@Metode_Pembayaran", byr.Metode_Pembayaran);
                cmd.Parameters.AddWithValue("@Total", byr.Total);

                try
                {
                    // jalankan perintah insert dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error : {0}", ex.Message);
                }
            }
            return result;
        }

        public decimal GetTotal()
        {
            decimal Total = 0;

            // Query SQL untuk menghitung jumlah total
            string sql = @"SELECT SUM(Total) FROM barang";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                try
                {
                    object result = cmd.ExecuteScalar();

                    // Jika hasilnya tidak null, konversi ke decimal
                    if (result != DBNull.Value)
                    {
                        Total = Convert.ToDecimal(result);
                    }
                }
                catch (Exception ex)
                {
                    // Tangani exception sesuai kebutuhan
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return Total;
        }

        public int Update(Pembayaran byr)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"update pembayaran set Nama = @Nama, Jenis_Pembayaran = @Jenis_Pembayaran, Metode_Pembayaran = @Metode_Pembayaran, Total = @Total
                           where Kd_Pembayaran = @Kd_Pembayaran";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@Kd_Pembayaran", byr.kd_Pembayaran);
                cmd.Parameters.AddWithValue("@Nama", byr.Nama);
                cmd.Parameters.AddWithValue("@Jenis_Pembayaran", byr.Jenis_Pembayaran);
                cmd.Parameters.AddWithValue("@Metode_Pembayaran", byr.Metode_Pembayaran);
                cmd.Parameters.AddWithValue("@Total", byr.Total);

                try
                {
                    // jalankan perintah UPDATE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }
            return result;
        }

        public int Delete(Pembayaran byr)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"delete from pembayaran
                           where Kd_Pembayaran = @Kd_Pembayaran";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@Kd_Pembayaran", byr.kd_Pembayaran);

                try
                {
                    // jalankan perintah DELETE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }
            return result;
        }

        public List<Pembayaran> ReadAll()
        {
            // membuat objek collection untuk menampung objek barang
            List<Pembayaran> list = new List<Pembayaran>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select Kd_Pembayaran, Nama, Jenis_Pembayaran, Metode_Pembayaran, Total 
                               from barang 
                               order by Kd_Pembayaran";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Pembayaran byr = new Pembayaran();
                            byr.kd_Pembayaran = dtr["Kd_Pembayaran"].ToString();
                            byr.Nama = dtr["Nama"].ToString();
                            byr.Jenis_Pembayaran = dtr["Jenis_Pembayaran"].ToString();
                            byr.Metode_Pembayaran = dtr["Metode_Pembayaran"].ToString();
                            byr.Total = byr.Total;

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(byr);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return list;
        }

        // Method untuk menampilkan data barang berdasarkan pencarian nama
        public List<Pembayaran> ReadByNama(string Nama)
        {
            // membuat objek collection untuk menampung objek barang
            List<Pembayaran> list = new List<Pembayaran>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select Kd_Pembayaran, Nama, Jenis_Pembayaran, Metode_Pembayaran, Total 
                               from pembayaran 
                               where Nama like @Nama
                               order by Nama";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@Nama", string.Format("%{0}%", Nama));

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Pembayaran byr = new Pembayaran();
                            byr.kd_Pembayaran = dtr["Kd_Pembayaran"].ToString();
                            byr.Nama = dtr["Nama"].ToString();
                            byr.Jenis_Pembayaran = dtr["Jenis_Pembayaran"].ToString();
                            byr.Metode_Pembayaran = dtr["Metode_Pembayaran"].ToString();
                            byr.Total = byr.Total;

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(byr);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNama error: {0}", ex.Message);
            }

            return list;
        }
    }
}
