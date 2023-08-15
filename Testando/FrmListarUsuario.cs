using Controller;
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
    public partial class FrmListarUsuario : Form
    {
        string sql; // 

        int valor; 
        UsuarioController uscontroller = new UsuarioController();
        Conexao usConexao = new Conexao();
        public FrmListarUsuario()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
            
            
            if (string.IsNullOrEmpty(txtPesquisar.Text))
            {
                sql = "SELECT * from usuario";
            }
            else
            {
                bool teste = int.TryParse(txtPesquisar.Text, out valor);
                if (teste)
                {
                    sql = "SELECT * from usuario where idusuario =" + valor;
                }
                else
                {
                    sql = "SELECT * from usuario where nome like '%" + txtPesquisar.Text + "%'";
                }
                
            }
            dtUsuario.DataSource = usConexao.ObterDados(sql);
        }

        private void FrmListarUsuario_Load(object sender, EventArgs e)
        {
            //sql = "SELECT * from usuario";
            //dtUsuario.DataSource = uscontroller.OberDados(sql);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            uscontroller.gerarPdf(sql);
        }
    }
}
