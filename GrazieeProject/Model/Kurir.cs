using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrazieeProject.Model
{
    class Kurir
    {
        private string id_kurir;
        private string nama_kurir;
        private string no_telp_kurir;
        private string alamat_kurir;

        public Kurir()
        {
            //default constructor
        }

        public Kurir(string idKurir, string namaKurir, string noTelp, string alamatKurir)
        {
            id_kurir = idKurir;
            nama_kurir = namaKurir;
            no_telp_kurir = noTelp;
            alamat_kurir = alamatKurir;
        }

        public string Id_kurir
        {
            set { id_kurir = value; }
            get { return id_kurir; }
        }

        public string Nama_kurir
        {
            set { nama_kurir = value; }
            get { return nama_kurir; }
        }

        public string No_telp_kurir
        {
            set { no_telp_kurir = value; }
            get { return no_telp_kurir; }
        }

        public string Alamat_kurir
        {
            set { alamat_kurir = value; }
            get { return alamat_kurir; }
        }
    }
}
