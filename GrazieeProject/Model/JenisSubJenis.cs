using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrazieeProject.Model
{
    class JenisSubJenis
    {
        private string id_jenis_sub_jenis;

        //Foreign Key fields
        private string jenis_id_jenis_barang_fk;
        private string sub_jenis_id_sub_jenis_barang_fk;

        public JenisSubJenis(string idJenisSubJenis, string jenisIdJenisBarangFk, string subJenisIdSubJenisBarangFk)
        {
            id_jenis_sub_jenis = idJenisSubJenis;
            jenis_id_jenis_barang_fk = jenisIdJenisBarangFk;
            sub_jenis_id_sub_jenis_barang_fk = subJenisIdSubJenisBarangFk;
        }

        public string Id_jenis_sub_jenis
        {
            set { id_jenis_sub_jenis = value; }
            get { return id_jenis_sub_jenis; }
        }

        public string Jenis_id_jenis_barang_fk
        {
            set { jenis_id_jenis_barang_fk = value; }
            get { return jenis_id_jenis_barang_fk; }
        }

        public string Sub_jenis_id_sub_jenis_barang_fk
        {
            set { sub_jenis_id_sub_jenis_barang_fk = value; }
            get { return sub_jenis_id_sub_jenis_barang_fk; }
        }
    }
}
