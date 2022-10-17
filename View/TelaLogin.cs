using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace CadastroPessoas
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle ctrl = new Controle();
            ctrl.acessar(txtbEmail.Text, txtbSenha.Text);

            if (ctrl.mensagem.Equals(""))
            {

                if (ctrl.loginOK)
                {
                    MessageBox.Show("Logado com sucesso!", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TelaPrincipal tlPrin = new TelaPrincipal();

                    tlPrin.Show();
                }
                else
                {
                    MessageBox.Show("Falha ao logar", "E-mail ou senha incorretos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show(ctrl.mensagem);
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TelaCadastro tlCad = new TelaCadastro();
            tlCad.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
