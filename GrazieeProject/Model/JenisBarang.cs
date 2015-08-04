using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrazieeProject.Model
{
    class JenisBarang
    {
        private string id_jenis_barang;
        private string nama_jenis;

        public JenisBarang(string idJenisBarang, string namaJenis)
        {
            id_jenis_barang = idJenisBarang;
            nama_jenis = namaJenis;
        }

        public string Id_jenis_barang
        {
            set { id_jenis_barang = value; }
            get { return id_jenis_barang; }
        }

        public string Nama_jenis
        {
            set { nama_jenis = value; }
            get { return nama_jenis; }
        }
    }
}
