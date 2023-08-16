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
            int codigoUsuario;
            UsuarioModelo us = new UsuarioModelo();
            UsuarioController usController = new UsuarioController();
            us.nome = "jorge"; //txtUsuarioLogin.Text;
            us.senha = "chefe";// txtSenhaLogin.Text;

            if (string.IsNullOrEmpty(us.nome))
            {
                MessageBox.Show("Nome vazio");
                txtUsuarioLogin.Focus();// retorna ao campo vazio para posterior preenchimento
            }
            if (string.IsNullOrEmpty(us.senha))
            {
                MessageBox.Show("Senha vazia");
                txtSenhaLogin.Focus(); // retorna ao campo vazio para posterior preenchimento
            }
            codigoUsuario = usController.logar(us); // guarda o id do usuario retornado da consulta

           // MessageBox.Show("Usuário  ID=" + codigoUsuario.ToString());
            if(usController.logar(us) >=1)
            {
                this.Hide(); // oculta a janela
                FrmPrincipal principal = new FrmPrincipal(codigoUsuario);
                principal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos");
            }
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
           // this.Hide();

            //this.Close();
        }

        private void btnCancelarLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}
