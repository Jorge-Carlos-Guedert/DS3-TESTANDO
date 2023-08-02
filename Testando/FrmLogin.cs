using Controller;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Testando
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            UsuarioModelo us = new UsuarioModelo();
            UsuarioController usController = new UsuarioController();
            us.nome = txtUsuarioLogin.Text;
            us.senha = txtSenhaLogin.Text;

            if (string.IsNullOrEmpty(us.nome))
            {
                MessageBox.Show("Nome vazio");
                txtUsuarioLogin.Focus();
            }
            if (string.IsNullOrEmpty(us.senha))
            {
                MessageBox.Show("Senha vazia");
                txtSenhaLogin.Focus();
            }

            if(usController.logar(us) == true)
            {
                FrmPrincipal principal = new FrmPrincipal();
                principal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos");
            }
        }
    }
}
