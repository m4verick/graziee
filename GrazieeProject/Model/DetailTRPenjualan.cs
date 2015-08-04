using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrazieeProject.Model
{
    class DetailTRPenjualan
    {
        private int jumlah_per_brg_penjualan;
        private int diskon_per_brg_penjualan;
        private int harga_tr_per_brg;
        private string status_brg_penjualan;

        //Foreign Key fields
        private string id_transaksi_penjualan_fk;
        private string id_detail_tr_pembelian_fk;
        private string id_barang_fk;

        public DetailTRPenjualan(int jumlah, int diskon, int harga, string status, string idTransaksiPenjualanFk, string idDetailTrPembelianFk, string idBarangFk)
        {
            jumlah_per_brg_penjualan = jumlah;
            diskon_per_brg_penjualan = diskon;
            harga_tr_per_brg = harga;
            status_brg_penjualan = status;
            id_transaksi_penjualan_fk = idTransaksiPenjualanFk;
            id_detail_tr_pembelian_fk = idDetailTrPembelianFk;
            id_barang_fk = idBarangFk;
        }

        public int Jumlah_per_brg_penjualan
        {
            set { jumlah_per_brg_penjualan = value; }
            get { return jumlah_per_brg_penjualan; }
        }

        public int Diskon_per_brg_penjualan
        {
            set { diskon_per_brg_penjualan = value; }
            get { return diskon_per_brg_penjualan; }
        }

        public int Harga_tr_per_brg
        {
            set { harga_tr_per_brg = value; }
            get { return harga_tr_per_brg; }
        }

        public string Status_brg_penjualan
        {
            set { status_brg_penjualan = value; }
            get { return status_brg_penjualan; }
        }

        public string Id_transaksi_penjualan_fk
        {
            set { id_transaksi_penjualan_fk = value; }
            get { return id_transaksi_penjualan_fk; }
        }

        public string Id_detail_tr_pembelian_fk
        {
            set { id_detail_tr_pembelian_fk = value; }
            get { return id_detail_tr_pembelian_fk; }
        }

        public string Id_barang_fk
        {
            set { id_barang_fk = value; }
            get { return id_barang_fk; }
        }
    }
}
