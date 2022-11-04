using DataAccessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPessoas
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Controle ctrl = new Controle();
            string mensagem = ctrl.cadastrar(txtbNome.Text, txtbCPF.Text, txtbEmail.Text, txtbTelefone.Text, txtbSenha.Text, txtbConfSenha.Text);

            if(ctrl.AcessoOk)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(ctrl.mensagem);
            }
           
        }
    }
}
