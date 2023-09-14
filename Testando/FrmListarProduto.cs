using Controller;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

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
                produto.BorderStyle = BorderStyle.FixedSingle; // borda do painel
                produto.Height = 250; 
                produto.Width = 250;
                Label idproduto = new Label();// crio uma label com id do produto
                idproduto.Name = "codigo"; // nomeio a label 
                idproduto.Text = dt.Rows[registros][0].ToString(); //mostra o registro carregado da linha coluna zero
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
                qtdproduto = Convert.ToDecimal(dt.Rows[registros][3].ToString()); // variavel recebe dados do DB 
                quantidade.Leave += new EventHandler((sender1, e1) => Quantidade_Leave(sender1, e1, quantidade.Text, qtdproduto));// evento deixar o foco do campo 
                
                if (qtdproduto > 0) // valida quantidade no BD
                {
                    quantidade.Enabled = true; // desabilita textbox quantidade
                }
                else
                {
                    quantidade.Enabled = false; // habilita textbox quantidade
                }


            




            // adicionando os componentes ao painel

            Button registrar = new Button();
            registrar.Name = "registrar";
            registrar.Location = new Point(20, 200);
            registrar.Text = "Selecionar";
            registrar.Font = new Font("Arial", 8);
            registrar.Height = 40;
            registrar.Width = 80;
            

            registrar.Click += new EventHandler((sender1, e1) => SelecionarClick(sender1, e1, idproduto.Text)); // chamo o evento do clicar botao


                //adiciono conmponentes no painel 
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
                               
                if (qtdproduto < Convert.ToInt32(quantidade) && Convert.ToInt32(quantidade) > 0)
                {
                    MessageBox.Show($"Quantidade indisponivel,\n\n Quantidade máxima: {qtdproduto}", "Alerta");

                }
                else if (qtdproduto < Convert.ToInt32(quantidade) || Convert.ToInt32(quantidade) <= 0)
                {
                    MessageBox.Show($"Insira uma quantidade válida:", "Alerta" );
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
