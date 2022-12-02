using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace studikasus_smk_nasional
{
    static internal class sql_utilities
    {
        static public SqlConnection con = new SqlConnection("Data Source=AKURADIARY-PC;Initial Catalog=smk_nasional;Integrated Security=True");
        static public SqlCommand cmd;
        static public SqlDataAdapter adapter = new SqlDataAdapter();
        static public SqlDataReader reader;
        static public DataTable dataTable = new DataTable();
    }
}
