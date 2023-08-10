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
    public partial class FrmPrincipal : Form
    {
        int idUsu; // crio a  variavel do id do usuario local
        UsuarioController usController = new UsuarioController(); // declaro os objetos para instanciar
        UsuarioModelo usModelo = new UsuarioModelo(); // declaro os objetos para instanciar
        public FrmPrincipal(int codigo) // passa o id por parametro do formprincipal
        {
            idUsu = codigo;
            MessageBox.Show("Seja bem vindo Id" + codigo);

            InitializeComponent();
        }



        private void usuárioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmUsuario usuario = new FrmUsuario();
            usuario.MdiParent = this;
            usuario.Show();
        }

        private void usuárioToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FrmListarUsuario frmListar = new FrmListarUsuario();
            frmListar.MdiParent = this;
            frmListar.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // carrego no usuario as Informações 
            usModelo = usController.CarregaUsuario(idUsu);
            

            if (usModelo.idperfil == 4)
            {
                usuárioToolStripMenuItem.Visible = true;
            }
            else if (usModelo.idperfil == 24)
            {
                usuárioToolStripMenuItem.Visible = false;
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();

            var result = MessageBox.Show("Deseja sair do sistema ?", "Sair do sistema:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                this.Hide();
                login.ShowDialog();
                this.Close();
            }
            
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduto  prod = new FrmProduto(); // criou o formulário  
            prod.MdiParent = this; // integra a janela
            prod.Show(); // mostrar a tela   
        }
    }
}
