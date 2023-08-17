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
using Modelo;
using System.Runtime.InteropServices;
using ZstdSharp.Unsafe;
using Microsoft.Win32;

namespace Testando
{
    public partial class FrmListarProduto : Form
    {
        Conexao conexao = new Conexao();

        public FrmListarProduto()
        {
            InitializeComponent();
        }

        private void FrmListarProduto_Load(object sender, EventArgs e)
        {
            //tabela de dados
            DataTable dt = new DataTable();
            dt = conexao.ObterDados("SELECT * from produto"); // buscando e populando a datatable
            int registros; //ler a quantidade de dados 
            int x = 0, y = 0; // Posição na Tela
            decimal qtdproduto; // guardar quantidade de itens no banco

            // percorrer ou varrer os registros
            for (registros = 0; registros < dt.Rows.Count; registros++)
            {
                Panel produto = new Panel(); // criando o painel de produto
                produto.Location = new Point(x, y);// defino o local
                produto.BorderStyle = BorderStyle.FixedSingle;
                produto.Height = 250;
                produto.Width = 250;
                Label idproduto = new Label();// crio uma label
                idproduto.Name = "codigo";
                idproduto.Text = dt.Rows[registros][0].ToString(); //mostra o registro
                //idproduto.Location = new Point(0, 0);
                PictureBox foto = new PictureBox();// crio area de foto
                foto.Location = new Point(20, 0);
                foto.SizeMode = PictureBoxSizeMode.StretchImage;
                foto.Name = "foto";
                foto.Image = Image.FromFile(dt.Rows[registros][6].ToString());
                //foto.Width = 80;
                //foto.Height = 60;
                Label preco = new Label();
                preco.Name = "preco";
                preco.Text = dt.Rows[registros][2].ToString();
                preco.Location = new Point(20, 80);
                Label descricaoProduto = new Label();
                descricaoProduto.Name = "desc_produto";
                descricaoProduto.Text = dt.Rows[registros][1].ToString();
                descricaoProduto.Location = new Point(20, 60);
                TextBox quantidade = new TextBox();
                quantidade.Name = "quantidade";

                quantidade.Location = new Point(20, 110);

                /*if (!string.IsNullOrEmpty(quantidade.Text)){


                      if (qtdproduto >= Convert.ToInt32(quantidade))
                      {
                          MessageBox.Show("Quantidade indisponivel", "Alerta");

                      }
                      */
                qtdproduto = Convert.ToDecimal(dt.Rows[registros][3].ToString());
                quantidade.Leave += new EventHandler((sender1, e1) => Quantidade_Leave(sender1, e1, quantidade.Text, qtdproduto));
                
                if (qtdproduto > 0)
                {
                    quantidade.Enabled = true;
                }
                else
                {
                    quantidade.Enabled = false;
                }


            




            // adicionando os componentes ao painel

            Button registrar = new Button();
            registrar.Name = "registrar";
            registrar.Location = new Point(20, 200);
            registrar.Text = "Selecionar";
            registrar.Font = new Font("Arial", 8);
            registrar.Height = 40;
            registrar.Width = 80;
            // chamo o evento do clicar botao

            registrar.Click += new EventHandler((sender1, e1) => SelecionarClick(sender1, e1, idproduto.Text));


            //adiciono conmponentes na tela
            produto.Controls.Add(preco);
            produto.Controls.Add(foto);
            produto.Controls.Add(idproduto);
            produto.Controls.Add(descricaoProduto);
            produto.Controls.Add(registrar);
            produto.Controls.Add(quantidade);

            flowLayoutPanel1.Controls.Add(produto);

            y += 100;
            x = 0;

        }            }
        

        
        

        private void SelecionarClick(object sender, EventArgs e, string Id)
        {
            MessageBox.Show("Produto selecionado" + Id);
        }

        private void Quantidade_Leave(object sender,EventArgs e,string quantidade,decimal qtdproduto)
        {
            if (!string.IsNullOrEmpty(quantidade))
            {
                               
                if (qtdproduto > Convert.ToInt32(quantidade) || Convert.ToInt32(quantidade) <= 0)
                {
                    MessageBox.Show("Quantidade indisponivel", "Alerta");

                }
            }
        }
    }
}
