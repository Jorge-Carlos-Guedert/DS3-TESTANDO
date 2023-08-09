using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{

    // meu objeto produto
    public class ProdutoModelo
    {
        private int codigo;
        private string descricao;
        private decimal preco;
        private float quantidade;
        private bool pericivel;
        private DateTime validade;
        private string foto;


        // contrutor da classe

        public ProdutoModelo()
        {
            // inicializando os valores default dos atributos do produto modelo
            this.codigo = 0;
            this.descricao = "";
            this.preco = 0;
            this.quantidade = 0;
            this.pericivel = false;
            this.validade = DateTime.Now;
            this.foto = "";

        }
        // metodo de acesso as variaveis
        public int codigoProduto
        {
            get { return codigo; } //obter dados da variavel

            set { codigo = value; } // alterar dados da variavel
        }

        public string descricaoProduto
        {
            get { return descricao; }

            set { descricao = value; }
        }

        public decimal precoProduto
        {
            get { return preco; }
            set { preco = value; }
        }

        public float quantidadeProduto
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        public bool pericivelProduto
        {
            get { return pericivel; }
            set { pericivel = value; }
        }

        public DateTime validadeProduto
        {
            get { return validade; }
            set
            {
                validade = value;
            }
        }

        public string fotoProduto
        {
            get { return foto; }
            set
            {
                foto = value;
            }
        }

    }
}
