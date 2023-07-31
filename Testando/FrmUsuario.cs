using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Controller;


namespace Testando
{
    public partial class FrmUsuario : Form

    {
        int codigo ;
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
           if( conexao.getConexao() == null)
            {
                MessageBox.Show("Erro na conexão");
            }
            else
            {
                MessageBox.Show("Acessando o Servidor");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioModelo usmodelo = new UsuarioModelo();

            usmodelo.nome = txtnome.Text;
            usmodelo.senha = txtsenha.Text;
            usmodelo.nomeCompleto = txtnomeCompleto.Text;
            usmodelo.email = txtEmail.Text;
            usmodelo.telefoneContato = txtTelContato.Text;
            usmodelo.whatsapp = txtwhatsapp.Text;
            usmodelo.endereco = txtEndCompleto.Text;
            usmodelo.ceb = txtCeb.Text;
            usmodelo.funcao= txtFuncao.Text;



            UsuarioController uscontrole =new UsuarioController();

            if (usmodelo.nome != "" && usmodelo.senha != "")
            {

                if (uscontrole.cadastrar(usmodelo) == true)
                {
                    MessageBox.Show("Usuário Cadastrado " + txtnome.Text);
                }
                else
                {
                    MessageBox.Show("Usuário Não Cadastrado");

                }
            }
            else
            {
                MessageBox.Show("Favor preencher todos os campos");
            }
        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // conevertendo a primeira celula em string
            codigo = Convert.ToInt32(dtUsuario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            // converte o inteiro para string
            MessageBox.Show("Usuario selecionado : " + codigo.ToString());
            txtnome.Text = dtUsuario.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtId.Text = dtUsuario.Rows[e.RowIndex].Cells["idusuario"].Value.ToString();
            txtsenha.Text = dtUsuario.Rows[e.RowIndex].Cells["senha"].Value.ToString();
            txtnomeCompleto.Text = dtUsuario.Rows[e.RowIndex].Cells["nomeCompleto"].Value.ToString();
            txtEmail.Text = dtUsuario.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtTelContato.Text = dtUsuario.Rows[e.RowIndex].Cells["telefoneContato"].Value.ToString();
            txtwhatsapp.Text = dtUsuario.Rows[e.RowIndex].Cells["whatsapp"].Value.ToString();
            txtEndCompleto.Text = dtUsuario.Rows[e.RowIndex].Cells["endereco"].Value.ToString();
            txtCeb.Text = dtUsuario.Rows[e.RowIndex].Cells["ceb"].Value.ToString();
            txtFuncao.Text = dtUsuario.Rows[e.RowIndex].Cells["funcao"].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // instanciar meu controller usuario
            UsuarioController usControle =new UsuarioController();
            dtUsuario.DataSource = usControle.OberDados("select * from usuario");
            MessageBox.Show("Seja bem vindo(a)");
        }

        private void dtUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // conevertendo a primeira celula em string
            codigo = Convert.ToInt32(dtUsuario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            // converte o inteiro para string
            MessageBox.Show("Usuario selecionado : " + codigo.ToString());
            txtnome.Text = dtUsuario.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtId.Text = dtUsuario.Rows[e.RowIndex].Cells["idusuario"].Value.ToString();
            txtsenha.Text = dtUsuario.Rows[e.RowIndex].Cells["senha"].Value.ToString();



        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            UsuarioController uscontroller = new UsuarioController();
            if (uscontroller.excluir(codigo) == true)
            {
                MessageBox.Show("código usuário " + codigo + "excluido com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao excluir usuário");
            }
        }

        private void btnListarUsuario_Click(object sender, EventArgs e)
        {
            // instancio o novo formulario
            FrmListarUsuario frmListar = new FrmListarUsuario();
            // exibir o formulario listar
            frmListar.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            UsuarioController usController = new UsuarioController();
            UsuarioModelo usModelo = new UsuarioModelo();
            usModelo.nome = txtnome.Text;
            usModelo.senha = txtsenha.Text;
            usModelo.idusuario = codigo;
            if (usController.editar(usModelo) == true)
            {
                MessageBox.Show("Usuário atualizado com sucesso!!");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar usuário!!");
            }
        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNome_Click(object sender, EventArgs e)
        {

        }

        private void cboxIguais_CheckedChanged(object sender, EventArgs e)
        {
            if(cboxIguais.Checked == true)
            {
                if(txtTelContato.Modified == true)
                {
                    txtwhatsapp = txtTelContato;
                }
            }
        }
    }
}
