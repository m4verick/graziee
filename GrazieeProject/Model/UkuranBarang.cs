using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrazieeProject.Model
{
    class UkuranBarang
    {
        private string id_ukuran_barang;
        private string ukuran_barang;

        public UkuranBarang(string idUkuranBarang, string ukuranBarang)
        {
            id_ukuran_barang = idUkuranBarang;
            ukuran_barang = ukuranBarang;
        }

        public string Id_ukuran_barang
        {
            set { id_ukuran_barang = value; }
            get { return id_ukuran_barang; }
        }

        public string Ukuran_barang
        {
            set { ukuran_barang = value; }
            get { return ukuran_barang; }
        }
    }
}
