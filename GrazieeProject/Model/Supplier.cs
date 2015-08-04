using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrazieeProject.Model
{
    class Supplier
    {
        private string id_supplier;
        private string nama_supplier;
        private string alamat_supplier;
        private string no_telp_supplier;

        public Supplier()
        {
            //default constructor
        }

        public Supplier(string idSupplier, string namaSupplier, string alamatSupplier, string noTelpSupplier)
        {
            id_supplier = idSupplier;
            nama_supplier = namaSupplier;
            alamat_supplier = alamatSupplier;
            no_telp_supplier = noTelpSupplier;
        }

        public string Id_supplier
        {
            set { id_supplier = value; }
            get { return id_supplier; }
        }

        public string Nama_supplier
        {
            set { nama_supplier = value; }
            get { return nama_supplier; }
        }

        public string Alamat_supplier
        {
            set { alamat_supplier = value; }
            get { return alamat_supplier; }
        }

        public string No_telp_supplier
        {
            set { no_telp_supplier = value; }
            get { return no_telp_supplier; }
        }
    }
}
