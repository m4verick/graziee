using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrazieeProject.Model
{
    class Barang
    {
        private string id_barang;
        private char gender;
        private int harga;
        private string status_stok;

        // Foreign Key fields
        private string ukuran_id_ukuran_barang_fk;
        private string warna_id_warna_barang_fk;
        private string model_id_model_barang_fk;
        private string merek_id_merek_barang_fk;
        private string supp_id_supplier_fk;
        private string jenis_sub_jenis_id_jenis_sub_jenis_fk;

        public Barang(string idBarang, char gendeR, int hrg, string statusStok, string idUkuranBarangFk, string idModelBarangFk, string idWarnaBarangFk, string idMerekBarangFk, string idSupplierFk, string idJenisSubJenisFk)
        {
            id_barang = idBarang;
            gender = gendeR;
            harga = hrg;
            status_stok = statusStok;
            ukuran_id_ukuran_barang_fk = idUkuranBarangFk;
            model_id_model_barang_fk = idModelBarangFk;
            merek_id_merek_barang_fk = idMerekBarangFk;
            warna_id_warna_barang_fk = idWarnaBarangFk;
            supp_id_supplier_fk = idSupplierFk;
            jenis_sub_jenis_id_jenis_sub_jenis_fk = idJenisSubJenisFk;
        }

        public string Id_barang
        {
            set { id_barang = value; }
            get { return id_barang; }
        }

        public char Gender
        {
            set { gender = value; }
            get { return gender; }
        }

        public int Harga
        {
            set { harga = value; }
            get { return harga; }
        }

        public string Status_stok
        {
            set { status_stok = value; }
            get { return status_stok; }
        }

        public string Ukuran_id_ukuran_barang_fk
        {
            set { ukuran_id_ukuran_barang_fk = value; }
            get { return ukuran_id_ukuran_barang_fk; }
        }

        public string Model_id_model_barang_fk
        {
            set { model_id_model_barang_fk = value; }
            get { return model_id_model_barang_fk; }
        }

        public string Merek_id_merek_barang_fk
        {
            set { merek_id_merek_barang_fk = value; }
            get { return merek_id_merek_barang_fk; }
        }

        public string Warna_id_warna_barang_fk
        {
            set { warna_id_warna_barang_fk = value; }
            get { return warna_id_warna_barang_fk; }
        }

        public string Supp_id_supplier_fk
        {
            set { supp_id_supplier_fk = value; }
            get { return supp_id_supplier_fk; }
        }

        public string Jenis_sub_jenis_id_jenis_sub_jenis_fk
        {
            set { jenis_sub_jenis_id_jenis_sub_jenis_fk = value; }
            get { return jenis_sub_jenis_id_jenis_sub_jenis_fk; }
        }
    }
}
