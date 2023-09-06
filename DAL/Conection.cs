using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetousuarios.DAL
{
    public class Conection
    {
        SqlConnection con = new SqlConnection();
        public Conection()
        {
            con.ConnectionString = @"Data Source=DESKTOP-IDTKEM3\SQLEXPRESS01;Initial Catalog=Jupiter;Integrated Security=True";
        }

        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public SqlConnection desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            return con;
        }
    }
}
