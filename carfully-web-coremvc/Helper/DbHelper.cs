using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace carfully_web_coremvc.Helper
{
    public class DbHelper
    {
        public DataTable OnlyConnectionString(string Con, string queryText)
        {
            using (DbDataAdapter adapter = new SqlDataAdapter(queryText, Con))
            {
                SqlConnection con = new SqlConnection(Con);
                SqlCommand cmd = new SqlCommand(queryText, con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTableCollection QueryToTableOnlyConnectionString(string Con, string queryText)
        {
            SqlConnection nwindConn = new SqlConnection(Con);
            SqlCommand selectCMD = new SqlCommand(queryText, nwindConn);
            selectCMD.CommandTimeout = 3000;
            SqlDataAdapter customerDA = new SqlDataAdapter();
            customerDA.SelectCommand = selectCMD;
            nwindConn.Open();
            DataSet customerDS = new DataSet();
            customerDA.Fill(customerDS, queryText.Trim());
            nwindConn.Close();

            return customerDS.Tables;
        }
    }
}