using Projetousuarios.forms;
using Projetousuarios.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projetousuarios
{
    public partial class CadastroUsuarios : Form
    {
        public CadastroUsuarios()
        {
            InitializeComponent();
        }

        private void entrar_Click(object sender, EventArgs e)
        {
            //validar a senha
            Controle controle = new Controle();
            controle.acessar(textUsuario.Text, textSenha.Text);

            if (controle.valida)
            {
                MessageBox.Show("Logado com Sucesso");

                //Chamada da tela de Aprovação de Notas Fiscais
                //AprovacaodeNotas apv = new AprovacaodeNotas();
                //apv.Show();
            }
            else
            {
                MessageBox.Show("Erro de usuario ou senha !!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
