using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrazieeProject.Model
{
    class TransaksiPenjualan
    {
        private string id_transaksi_penjualan;
        private DateTime tgl_tr_penjualan;
        private string jenis_pembayaran;
        private int points;
        private int ongkos_kirim;
        private int diskon_tr_penjualan;

        public TransaksiPenjualan(string idTrPenjualan, DateTime tglTrPenjualan, string jnsPembayaran, int point, int ongkosKirim, int diskonTrPenjualan)
        {
            id_transaksi_penjualan = idTrPenjualan;
            tgl_tr_penjualan = tglTrPenjualan;
            jenis_pembayaran = jnsPembayaran;
            points = point;
            ongkos_kirim = ongkosKirim;
            diskon_tr_penjualan = diskonTrPenjualan;
        }

        public string Id_transaksi_penjualan
        {
            set { id_transaksi_penjualan = value; }
            get { return id_transaksi_penjualan; }
        }

        public DateTime Tgl_tr_penjualan
        {
            set { tgl_tr_penjualan = value; }
            get { return tgl_tr_penjualan; }
        }

        public string Jenis_pembayaran
        {
            set { jenis_pembayaran = value; }
            get { return jenis_pembayaran; }
        }

        public int Points
        {
            set { points = value; }
            get { return points; }
        }

        public int Ongkos_kirim
        {
            set { ongkos_kirim = value; }
            get { return ongkos_kirim; }
        }

        public int Diskon_tr_penjualan
        {
            set { diskon_tr_penjualan = value; }
            get { return diskon_tr_penjualan; }
        }
    }
}
