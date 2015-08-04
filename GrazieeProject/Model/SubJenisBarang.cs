using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrazieeProject.Model
{
    class SubJenisBarang
    {
        private string id_sub_jenis_barang;
        private string nama_sub_jenis;

        public SubJenisBarang(string idSubJenisBarang, string namaSubJenis)
        {
            id_sub_jenis_barang = idSubJenisBarang;
            nama_sub_jenis = namaSubJenis;
        }

        public string Id_sub_jenis_barang
        {
            set { id_sub_jenis_barang = value; }
            get { return id_sub_jenis_barang; }
        }

        public string Nama_sub_jenis
        {
            set { nama_sub_jenis = value; }
            get { return nama_sub_jenis; }
        }
    }
}
