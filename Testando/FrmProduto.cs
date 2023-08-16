using Controller;
using Google.Protobuf.WellKnownTypes;
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
    
    public partial class FrmProduto : Form
    {
            // instanciar o objeto produto
            ProdutoModelo produtoModelo = new ProdutoModelo();
        ProdutoController pController = new ProdutoController();
        Conexao pConexao = new Conexao();
        
        string sql;
        int codigoProduto;
        public FrmProduto()
        {
            InitializeComponent();
            
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            try
            {

            produtoModelo.descricaoProduto = txtDescricao.Text;
            //produtoModelo.precoProduto = Convert.ToDecimal(txtPreco.Text);
            produtoModelo.precoProduto = Convert.ToDecimal(txtPreco.Text);
            //MessageBox.Show($"{produtoModelo.precoProduto}");
            produtoModelo.quantidadeProduto = Convert.ToDecimal(txtQuantidade.Text);
            //MessageBox.Show($"{produtoModelo.quantidadeProduto}");

            produtoModelo.validadeProduto = dateValidade.Value;

            if (checkBoxPerecivel.Checked) 
            { 
                produtoModelo.pericivelProduto = true ;
               // MessageBox.Show($"{produtoModelo.pericivelProduto}");
                
                
            } else 
            { 
                produtoModelo.pericivelProduto = false ; 
            }

            produtoModelo.fotoProduto = lblFoto.Text;

                

            
            if(pController.cadastrarProduto(produtoModelo,1) == true)
            {
                MessageBox.Show("Cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro no cadastro");
            }
            } catch(Exception )
            {
              MessageBox.Show("Preencha os campos para serem inseridos : "  );
            }



        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog foto = new OpenFileDialog(); // chamo a caixa de dialogo para a foto
                foto.Filter = "Image File(*.jpg; *.png; *.gif) | *.jpg; *.png; *.gif";
                if(foto.ShowDialog() == DialogResult.OK)
                {
                    lblFoto.Visible = true;
                    lblFoto.Text = foto.FileName; // mostra o nome e caminho da foto

                    Image arquivo = Image.FromFile(foto.FileName);  // caminho da imagem para ser exibido no forms
                    ptbFoto.Image = arquivo; // carrega a foto   
                }
                else
                {
                    MessageBox.Show("Selecione um Arquivo para a foto:");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }  
        }

        private void checkBoxPerecivel_Click(object sender, EventArgs e)
        {
            if (checkBoxPerecivel.Checked)
            {
                lblValidade.Visible = true;
                dateValidade.Visible=true;


            }
            else
            {
                lblValidade.Visible = false;
                dateValidade.Visible = false;
            }
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            lblFoto.Visible = false;
            lblValidade.Visible = false;
            dateValidade.Visible = false;
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            char delete = (char)8; //codigo ascii para o backspace
            e.Handled =!char.IsDigit(e.KeyChar) && e.KeyChar != delete && e.KeyChar != (char)44;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            produtoModelo.descricaoProduto = txtDescricao.Text;
            produtoModelo.precoProduto = Convert.ToDecimal(txtPreco.Text);
            produtoModelo.quantidadeProduto = Convert.ToDecimal(txtQuantidade.Text);
            
            produtoModelo.codigoProduto = Convert.ToInt32(txtCodigo.Text);

            if (checkBoxPerecivel.Checked)
            {
                produtoModelo.pericivelProduto = true;
            }
            else
            {
                produtoModelo.pericivelProduto= false;
            }
            produtoModelo.validadeProduto = dateValidade.Value;
            produtoModelo.fotoProduto = lblFoto.Text;

            if(pController.cadastrarProduto(produtoModelo,2) == true)
            {
                MessageBox.Show("Atualizado com Sucesso !");
            }
            else
            {
                MessageBox.Show("Erro na Atualização");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //produtoModelo.codigoProduto = Convert.ToInt32(txtCodigo.Text);


                if (string.IsNullOrEmpty(produtoModelo.codigoProduto.ToString()))
                {
                    MessageBox.Show("Código está vazio :");

                }
                else
                {

                    if (pController.cadastrarProduto(produtoModelo, 3) == true)
                    {
                        MessageBox.Show("Produto excluido com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel excluir o produto indicado");
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
        }

        private void ptbFoto_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesquisarProduto.Text))
            {
                sql = "SELECT * from produto";
            }
            else
            {
                bool teste = int.TryParse(txtPesquisarProduto.Text, out codigoProduto);
                if (teste)
                {
                    sql = "SELECT * from produto where codigo =" + codigoProduto;
                }
                else
                {
                    sql = "SELECT * from produto where nome like '%" + txtPesquisarProduto.Text + "%'";
                }

            }
            dtProduto.DataSource = pConexao.ObterDados(sql);
        }

        private void dtProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            produtoModelo.codigoProduto = Convert.ToInt32(dtProduto.Rows[e.RowIndex].Cells[0].Value);
            txtCodigo.Text = produtoModelo.codigoProduto.ToString();
            txtDescricao.Text = dtProduto.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPreco.Text = dtProduto.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtQuantidade.Text = dtProduto.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (Convert.ToUInt32(dtProduto.Rows[e.RowIndex].Cells[4].Value)==1)
                {
                checkBoxPerecivel.Checked = true;
            }
            else
            {
                checkBoxPerecivel.Checked = false;
            }

            dateValidade.Value = Convert.ToDateTime(dtProduto.Rows[e.RowIndex].Cells[5].Value);
            ptbFoto.Image = Image.FromFile(dtProduto.Rows[e.RowIndex].Cells[6].Value.ToString());
            
           //if( pController.cadastrarProduto(produtoModelo, 3) == true);
           // {
           //     MessageBox.Show("Produto excluido com sucesso");
           // } else
           // {
           //     MessageBox.Show("Não foi possível excluir o produto selecionado");
           // }

        }
    }
}
