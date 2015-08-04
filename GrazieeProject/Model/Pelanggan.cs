using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrazieeProject.Model
{
    class Pelanggan
    {
        private string id_pelanggan;
        private string nama_pelanggan;
        private string alamat_pelanggan;
        private string no_telp_pelanggan;

        public Pelanggan()
        { 
        }

        public Pelanggan(string idPelanggan, string namaPelanggan, string alamatPelanggan, string noTelpPelanggan)
        {
            id_pelanggan = idPelanggan;
            nama_pelanggan = namaPelanggan;
            alamat_pelanggan = alamatPelanggan;
            no_telp_pelanggan = noTelpPelanggan;
        }

        public string Id_pelanggan
        {
            set { id_pelanggan = value; }
            get { return id_pelanggan; }
        }

        public string Nama_pelanggan
        {
            set { nama_pelanggan = value; }
            get { return nama_pelanggan; }
        }

        public string Alamat_pelanggan
        {
            set { alamat_pelanggan = value; }
            get { return alamat_pelanggan; }
        }

        public string No_telp_pelanggan
        {
            set { no_telp_pelanggan = value; }
            get { return no_telp_pelanggan; }
        }
    }
}
