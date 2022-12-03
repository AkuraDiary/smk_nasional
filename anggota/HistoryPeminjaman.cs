using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace studikasus_smk_nasional.anggota
{
    public partial class HistoryPeminjaman : UserControl
    {
        private DataTable dataTable = new DataTable();

        public HistoryPeminjaman()
        {
            InitializeComponent();
            
        }

        private void getPeminjamanData()
        {
            dataTable.Clear();
            sql_utilities.con.Open();
            string query = "select buku.kode_buku, judul, nama_kat, nama_lengkap, tgl_pinjam, tgl_kembali from peminjaman_buku join buku on buku.kode_buku = peminjaman_buku.kode_buku join kategorri on kategorri.id_kat = buku.id_kat join peminjaman on peminjaman.id_pinjam = peminjaman_buku.id_pinjam inner join anggota on anggota.id_anggota = peminjaman.id_anggota inner join [User] on [User].id_user = '" + utilities.currentUser.id_user +"'";
            sql_utilities.cmd = new SqlCommand(query, sql_utilities.con);
            

            sql_utilities.adapter.SelectCommand = sql_utilities.cmd; //new SqlDataAdapter(sql_utilities.cmd);

            sql_utilities.adapter.Fill(dataTable);

            dataBuku.DataSource = dataTable;

            sql_utilities.con.Close();
        }

        private void HistoryPeminjaman_Load(object sender, EventArgs e)
        {
            getPeminjamanData();
        }
        
        private void searchForBook(string judul)
        {
            sql_utilities.con.Open();
            string query = "select buku.kode_buku, judul, nama_kat, nama_lengkap, tgl_pinjam, tgl_kembali from peminjaman_buku join buku on buku.kode_buku = peminjaman_buku.kode_buku join kategorri on kategorri.id_kat = buku.id_kat join peminjaman on peminjaman.id_pinjam = peminjaman_buku.id_pinjam inner join anggota on anggota.id_anggota = peminjaman.id_anggota inner join [User] on [User].id_user = '" + utilities.currentUser.id_user + "'where judul like '%" + judul + "%'";
            sql_utilities.cmd = new SqlCommand(query, sql_utilities.con);


            sql_utilities.adapter.SelectCommand = sql_utilities.cmd; //new SqlDataAdapter(sql_utilities.cmd);

            sql_utilities.adapter.Fill(dataTable);

            dataBuku.DataSource = dataTable;

            sql_utilities.con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(edtSearchBook.Text))
            {
                dataTable.Clear();
                searchForBook(edtSearchBook.Text);
            }
            
        }
    }
}
