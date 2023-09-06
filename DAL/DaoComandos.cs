using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetousuarios.DAL
{
    class DaoComandos
    {
        public bool valida = false;
        public String error = "";
        SqlCommand cmd = new SqlCommand();
        Conection con = new Conection();
        SqlDataReader reader;

        public bool verificaUsuario(String usuario, String senha)
        {
            cmd.CommandText = "select * from Historico_Aprovacao where usuario = @usuario and senha = @senha";
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.conectar();
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    valida = true;
                }

            }
            catch (SqlException) 
            {
                this.error = "Erro no Banco de Dados";
            }

            return valida;
        }

        public String cadastrar(String aprovado, decimal valorMinimo, decimal valorMaximo)
        {
            return error;
        }
    }
}
