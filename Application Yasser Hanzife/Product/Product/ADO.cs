using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;



namespace Product
{
    class ADO
    {
        //declaration des object
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();

        // declaration de la methode connecter
        public void conected()
        {
            if(con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
            {
                con.ConnectionString = @"Data Source=DESKTOP-IKEFCK7\SQLEXPRESS;Initial Catalog=stock01;Integrated Security=True";
                con.Open();
            }
        }
        // declaration de la methode Deconnecter
        public void disconected()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

    }
}
