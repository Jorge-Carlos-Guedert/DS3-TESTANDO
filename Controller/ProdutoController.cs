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

        public bool cadastrarProduto (ProdutoModelo prod, int operacao)
        {
            try
            {
                switch (operacao)
                {
                    case 1: // inserir dados
                        sql = "INSERT INTO produto ( descricao, preco, quantidade, perecivel, validade, foto)" + "values ( @descricao, @preco, @quantidade, @perecivel, @validade, @foto)";
                        break;

                    case 2: // atualizar dados
                        sql = " UPDATE produto set descricao=@descricao, preco=@preco, quantidade=@quantidade, perecivel=@perecivel, validade = @validade, foto = @foto" +
                            " where codigo = @id";
                        break ;
                    
                    case 3: // deleta dados
                        sql = "DELETE from produto where codigo = @id";
                        break;
                    default:
                        break;
                }
                //sql = "INSERT INTO produto( descricao, preco, quantidade, perecivel, validade, foto)" + "values ( @descricao, @preco, @quantidade, @perecivel, @validade, @foto)";

                string[] campos = { "@descricao", "@preco", "@quantidade", "@perecivel", "@validade", "@foto" };

                object[] valores = {  prod.descricaoProduto, prod.precoProduto, prod.quantidadeProduto, prod.pericivelProduto, prod.validadeProduto, prod.fotoProduto };

                if (con.cadastrar(prod.codigoProduto, campos, valores, sql) >= 1)
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
