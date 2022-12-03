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
    public partial class CariBukuForm : UserControl
        
    {
        private DataTable dataTable = new DataTable();
        public CariBukuForm()
        {
            InitializeComponent();
            dataTable.Clear();
        }

        private void CariBukuForm_Load(object sender, EventArgs e)
        {

            showAllBook();
        }

        private void showAllBook()
        {
            sql_utilities.con.Open();
            string query = "Select kode_buku, judul, penulis, penerbit, nama_kat, lantai, rak, label, stok from buku join kategorri on kategorri.id_kat = buku.id_kat join lokasi on lokasi.kode_lokasi = buku.kode_lokasi";
            sql_utilities.cmd = new SqlCommand(query, sql_utilities.con);
            

            sql_utilities.adapter.SelectCommand = sql_utilities.cmd; //new SqlDataAdapter(sql_utilities.cmd);

            sql_utilities.adapter.Fill(dataTable);

            dataBuku.DataSource = dataTable;

            sql_utilities.con.Close();
        }

        private void cariBuku_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(edtSearchBook.Text)){
                sql_utilities.con.Open();
                string query = "Select kode_buku, judul, penulis, penerbit, nama_kat, lantai, rak, label, stok from buku join kategorri on kategorri.id_kat = buku.id_kat join lokasi on lokasi.kode_lokasi = buku.kode_lokasi where judul like '%" + edtSearchBook.Text + "%'";
                sql_utilities.cmd = new SqlCommand(query, sql_utilities.con);

                dataTable.Clear(); // clear the data table

                sql_utilities.adapter.SelectCommand = sql_utilities.cmd; //new SqlDataAdapter(sql_utilities.cmd);

                sql_utilities.adapter.Fill(dataTable);

                dataBuku.DataSource = dataTable;

                sql_utilities.con.Close();
            }
        }

        
    }
}
