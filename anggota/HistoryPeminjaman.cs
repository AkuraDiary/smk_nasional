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
        public HistoryPeminjaman()
        {
            InitializeComponent();
        }

        private void getPeminjamanData()
        {
            sql_utilities.con.Open();
            string query = "select id, id_pinjam, kode_buku, tgl_pinjam, tgl_kembali from peminjaman_buku where id_pinjam = (Select id_pinjam from peminjaman where id_anggota=(select id_anggota from anggota where id_user =  '" + utilities.currentUser.id_user + "' ))";
            sql_utilities.cmd = new SqlCommand(query, sql_utilities.con);
            sql_utilities.dataTable.Clear();

            sql_utilities.adapter.SelectCommand = sql_utilities.cmd; //new SqlDataAdapter(sql_utilities.cmd);

            sql_utilities.adapter.Fill(sql_utilities.dataTable);

            dataBuku.DataSource = sql_utilities.dataTable;

            sql_utilities.con.Close();
        }

        private void HistoryPeminjaman_Load(object sender, EventArgs e)
        {
            getPeminjamanData();
        }
    }
}
