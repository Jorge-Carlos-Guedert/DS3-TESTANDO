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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // instanciar o objeto produto
            ProdutoModelo produtoModelo = new ProdutoModelo();

            
            produtoModelo.descricaoProduto = txtDescricao.Text;
            //produtoModelo.precoProduto = Convert.ToDecimal(txtPreco.Text);
            produtoModelo.precoProduto = Convert.ToDouble(txtPreco.Text);
            MessageBox.Show($"{produtoModelo.precoProduto}");
            produtoModelo.quantidadeProduto = Convert.ToDouble(txtQuantidade.Text);
            MessageBox.Show($"{produtoModelo.quantidadeProduto}");

            produtoModelo.validadeProduto = dateValidade.Value;

            if (checkBoxPerecivel.Checked) 
            { 
                produtoModelo.pericivelProduto = true ;
                MessageBox.Show($"{produtoModelo.pericivelProduto}");
            } else 
            { 
                produtoModelo.pericivelProduto = false ; 
            }

            ProdutoController pController = new ProdutoController();
            if(pController.cadastrarProduto(produtoModelo) == true)
            {
                MessageBox.Show("Cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro no cadastro");
            }



        }
    }
}
