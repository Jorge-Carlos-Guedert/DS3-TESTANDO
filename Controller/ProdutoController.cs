using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo; // importar Objeto

namespace Controller
{
    public class ProdutoController
    {
        bool resultado = false; // verificar o resultado
        string sql;// estrutura sql
        Conexao con = new Conexao(); // chamo o metodo conexao

        public bool cadastrarProduto (ProdutoModelo prod)
        {
            try
            {
                sql = "INSERT INTO produto( descricao, preco, quantidade, perecivel, validade, foto)" + "values ( @descricao, @preco, @quantidade, @perecivel, @validade, @foto)";

                string[] campos = { "@descricao", "@preco", "@quantidade", "@perecivel", "@validade", "@foto" };

                object[] valores = { prod.descricaoProduto, prod.precoProduto, prod.quantidadeProduto, prod.pericivelProduto, prod.validadeProduto, prod.fotoProduto };

                if (con.cadastrar(campos, valores, sql) >= 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                return resultado;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
