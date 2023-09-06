using Projetousuarios.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetousuarios.model
{
    public class Controle
    {
        public bool valida;
        public String error = "";

        public bool acessar(String usuario, String senha)
        {
            DaoComandos dao = new DaoComandos();
            valida = dao.verificaUsuario(usuario, senha);

            if (!dao.error.Equals(""))
            {
                this.error = dao.error;
            }
            return valida;
        }

    }
}
