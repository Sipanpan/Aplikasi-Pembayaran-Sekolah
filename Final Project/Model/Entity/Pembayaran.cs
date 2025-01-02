using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Model.Entity
{
    public class Pembayaran
    {
        public string Kd_Pembayaran { get; set; }
        public string Nama { get; set; }
        public string Metode_Pembayaran { get; set; }
        public string Jenis_Pembayaran { get; set; }
        public int Total { get; set; }
    }
}
