using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // biblioteca para o cliente Mysql

namespace Controller
{
    // classe de conexao com banco de dados
    public class Conexao
    {
        // atributos da conexao
        static private string servidor = "us-cdbr-east-06.cleardb.net";
        static private string db = "heroku_e56db92fefe024d";
        static private string usuario = "b18f10f8ad9d79";
        static private string senha = "eabbaedc";
        static private string StrCon = "server=" + servidor + ";database="
 + db + ";user id=" + usuario + ";password=" + senha; 
        // metodo de obter a conexao com o mySql

        public MySqlConnection getConexao()
        {
            // define a variavel conexao instanciando uma nova conexao
            MySqlConnection conexao = new MySqlConnection(StrCon);
            return conexao; // retorno o valor da conexao

        }
    }
}
