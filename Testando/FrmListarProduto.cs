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

            // percorrer ou varrer os registros
            for(registros = 0; registros < dt.Rows.Count; registros++)
            {
                Panel produto = new Panel(); // criando o painel de produto
                produto.Location = new Point(0, 0);// defino o local 
                Label idproduto = new Label();// crio uma label
                idproduto.Name = "codigo";
                idproduto.Text = dt.Rows[registros].ToString(); //mostra o registro
                PictureBox foto = new PictureBox();// crio area de foto
                foto.Location = new Point(10, 0);
                foto.SizeMode = PictureBoxSizeMode.StretchImage;
                foto.Name = "foto";
                foto.Image = Image.FromFile(dt.Rows[registros][6].ToString());
                Label preco = new Label();
                preco.Name = "preco";
                preco.Text = dt.Rows[registros][2].ToString();
                preco.Location= new Point(20, 0);

                produto.Controls.Add(preco);
                produto.Controls.Add(foto);
                produto.Controls.Add(idproduto);
                //adiciono cada produto da con
                panel1.Controls.Add(produto);
            }
        }
    }
}
