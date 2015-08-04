using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrazieeProject.Model
{
    class ModelBarang
    {
        private string id_model_barang;
        private string nama_model;

        public ModelBarang(string idModelBarang, string namaModel)
        {
            id_model_barang = idModelBarang;
            nama_model = namaModel;
        }

        public string Id_model_barang
        {
            set { id_model_barang = value; }
            get { return id_model_barang; }
        }

        public string Nama_model
        {
            set { nama_model = value; }
            get { return nama_model; }
        }
    }
}
