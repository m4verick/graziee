using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrazieeProject.Model
{
    class WarnaBarang
    {
        private string id_warna_barang;
        private string nama_warna;

        public WarnaBarang(string idWarnaBarang, string namaWarna)
        {
            id_warna_barang = idWarnaBarang;
            nama_warna = namaWarna;
        }

        public string Id_warna_barang
        {
            set { id_warna_barang = value; }
            get { return id_warna_barang; }
        }

        public string Nama_warna
        {
            set { nama_warna = value; }
            get { return nama_warna; }
        }
    }
}
