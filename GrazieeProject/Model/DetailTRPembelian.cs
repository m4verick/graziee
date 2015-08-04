using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrazieeProject.Model
{
    class DetailTRPembelian
    {
        private string id_detail_tr_pembelian;
        private int harga_modal;
        private int stok_brg_beli;

        //Foreign Key fields
        private string id_transaksi_pembelian_fk;
        private string id_barang_fk;

        public DetailTRPembelian(string idDetailTrPembelian, int hargaModal, int stokBrgBeli, string idTransaksiPembelianFk, string idBarangFk)
        {
            id_detail_tr_pembelian = idDetailTrPembelian;
            harga_modal = hargaModal;
            stok_brg_beli = stokBrgBeli;
            id_transaksi_pembelian_fk = idTransaksiPembelianFk;
            id_barang_fk = idBarangFk;
        }

        public string Id_detail_tr_pembelian
        {
            set { id_detail_tr_pembelian = value; }
            get { return id_detail_tr_pembelian; }
        }

        public int Harga_modal
        {
            set { harga_modal = value; }
            get { return harga_modal; }
        }

        public int Stok_hrg_beli
        {
            set { stok_brg_beli = value; }
            get { return stok_brg_beli; }
        }

        public string Id_transaksi_pembelian_fk
        {
            set { id_transaksi_pembelian_fk = value; }
            get { return id_transaksi_pembelian_fk; }
        }

        public string Id_barang_fk
        {
            set { id_barang_fk = value; }
            get { return id_barang_fk; }
        }
    }
}
