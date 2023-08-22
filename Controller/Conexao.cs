using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
        public MySqlConnection conn = null; // minha conexão
        // metodo de obter a conexao com o mySql

        public MySqlConnection getConexao()
        {
            // define a variavel conexao instanciando uma nova conexao
            MySqlConnection conexao = new MySqlConnection(StrCon);
            return conexao; // retorno o valor da conexao

        }

        public int cadastrar(int codigo, string[]campos, object[]valores, string sql)
        {
            int registro = 0;
            try // testar o cadastro
            {
                conn = getConexao();// chamo obter conexao
                conn.Open();// abro a minha conexao
                // preparo o comando sql
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                // monto paramentros do sql

                for (int i = 0; i < valores.Length; i++)
                {
                    cmd.Parameters.AddWithValue(campos[i], valores[i]);
                }
                if (codigo > 0)
                {
                    cmd.Parameters.AddWithValue("id", codigo);
                }
                registro = cmd.ExecuteNonQuery();
                conn.Close();

            } // se houver erro
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return registro;

        }

        public int atualizar(string[]campos, object[]valores, string sql)
        {
            int registro = 0;


            return registro;
        }
        
        public DataTable ObterDados(string sql)
        {
            // crio uma nova tabela de dados
            DataTable dt = new DataTable();
            MySqlConnection conn = getConexao();
            conn.Open(); // abre banco de dados
            // preparo o commando sql
            MySqlCommand sqlCon = new MySqlCommand(sql, conn);
            //tipo de instrução de texto
            sqlCon.CommandType = System.Data.CommandType.Text;
            sqlCon.CommandText = sql;
            MySqlDataAdapter dados = new MySqlDataAdapter(sqlCon);
            dados.Fill(dt);// montar a tabela de dados
            conn.Close();
            return dt;// retorna a tabela de dados
        }

        public string getMD5Hash(string senha)
        {
            System.Security.Cryptography.MD5 md5 =System.Security.Cryptography.MD5.Create();
            byte[] inmpuBytes= System.Text.Encoding.ASCII.GetBytes(senha);
            byte[] hash= md5.ComputeHash(inmpuBytes);
            StringBuilder sb=new StringBuilder();
            for(int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
