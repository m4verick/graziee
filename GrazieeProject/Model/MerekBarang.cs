using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrazieeProject.Model
{
    class MerekBarang
    {
        private string id_merek_barang;
        private string nama_merek;

        public MerekBarang(string idMerekBarang, string namaMerek)
        {
            id_merek_barang = idMerekBarang;
            nama_merek = namaMerek;
        }

        public string Id_merek_barang
        {
            set { id_merek_barang = value; }
            get { return id_merek_barang; }
        }

        public string Nama_merek
        {
            set { nama_merek = value; }
            get { return nama_merek; }
        }
    }
}
