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

            // percorrer ou varrer os registros
            for(registros = 0; registros < dt.Rows.Count; registros++)
            {
                Panel produto = new Panel(); // criando o painel de produto
                produto.Location = new Point(x, y);// defino o local
                produto.BorderStyle = BorderStyle.FixedSingle;
                produto.Height = 250;
                produto.Width = 250;
                Label idproduto = new Label();// crio uma label
                idproduto.Name = "codigo";
                idproduto.Text = dt.Rows[registros][0].ToString(); //mostra o registro
                idproduto.Location = new Point(0, 0);
                PictureBox foto = new PictureBox();// crio area de foto
                foto.Location = new Point(25,0);
                foto.SizeMode = PictureBoxSizeMode.StretchImage;
                foto.Name = "foto";
                foto.Image = Image.FromFile(dt.Rows[registros][6].ToString());
                //foto.Width = 150;
                //foto.Height = 100;
                Label preco = new Label();
                preco.Name = "preco";
                preco.Text = dt.Rows[registros][2].ToString();
                preco.Location= new Point(20, 75);
                Label descricaoProduto = new Label();
                descricaoProduto.Name = "desc_produto";
                descricaoProduto.Text = dt.Rows[registros][1].ToString();
                descricaoProduto.Location= new Point(20,55);
                TextBox quantidade = new TextBox();
                quantidade.Name = "quantidade";
                quantidade.Location = new Point(20, 110);

                // adicionando os componentes ao painel

                Button registrar = new Button();
                registrar.Name = "registrar";
                registrar.Location = new Point(20, 140);
                registrar.Text = "Selecionar";
                registrar.Font = new Font("Arial", 8);
                //registrar.Height = 200;
                //registrar.Width = 200;
                
                registrar.Click += new EventHandler((sender1, e1) => SelecionarClick(sender1, e1, idproduto.Text));

                produto.Controls.Add(preco);
                produto.Controls.Add(foto);
                produto.Controls.Add(idproduto);
                produto.Controls.Add(descricaoProduto);
                produto.Controls.Add(registrar);
                preco.Controls.Add(quantidade);
                //adiciono cada produto da con
                flowLayoutPanel1.Controls.Add(produto);

                y += 80;
                x = 0;

            }
        }
        private void SelecionarClick(object sender, EventArgs e, string Id)
        {
            MessageBox.Show("Produto selecionado" + Id);
        }
    }
}
