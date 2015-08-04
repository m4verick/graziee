using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrazieeProject.Model
{
    class TransaksiPembelian
    {
        private string id_transaksi_pembelian;
        private DateTime tgl_tr_pembelian;

        public TransaksiPembelian(string idTrPembelian, DateTime tglTrPembelian)
        {
            id_transaksi_pembelian = idTrPembelian;
            tgl_tr_pembelian = tglTrPembelian;
        }

        public string Id_transaksi_pembelian
        {
            set { id_transaksi_pembelian = value; }
            get { return id_transaksi_pembelian; }
        }

        public DateTime Tgl_tr_pembelian
        {
            set { tgl_tr_pembelian = value; }
            get { return tgl_tr_pembelian; }
        }
    }
}
