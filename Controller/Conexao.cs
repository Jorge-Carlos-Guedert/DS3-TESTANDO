using System;
using System.Data;
using System.Net.Mail;
using System.Text;
using Modelo;
using MySql.Data.MySqlClient; // biblioteca para o cliente Mysql

namespace Controller
{
    // classe de conexao com banco de dados
    public class Conexao
    {
        // atributos da conexao
        static private string servidor = "db4free.net";
        static private string db = "aulads3";
        static private string usuario = "jorgecguedert";
        static private string senha = "Lander@255";
        static private string StrCon = "server=" + servidor + ";database="
 + db + ";user id=" + usuario + ";password=" + senha;
        public MySqlConnection conn = null; // minha conexão

        UsuarioModelo usuarioModelo = new UsuarioModelo(); // estancio um UsuarioModelo

        Random Random = new Random();

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

        public string recuperaremail(string login)
        { // testar a recuperação

            try
            {
                DataTable dt = new DataTable();
            string msg = null; //validação
               
                if(login == null)
                {
                    msg = "Login está vazio";
                }
                else
                {
                    conn = getConexao(); // conectar com o DB
                    conn.Open(); // Abrir o DB
                    dt = ObterDados("SELECT * FROM heroku_e56db92fefe024d.usuario where nome ='"+login+"'");

                    if (dt.Rows.Count > 0)
                    {

                        string email = "joca12855@outlook.com";
                        string senha = "Lander@92612855";
                        string emailUsuario = "";
                        // chamar o acesso ao email

                        SmtpClient cliente = new SmtpClient(); // chamar o acesso ao email
                        cliente.Host = "smtp.office365.com"; // chamo o servidor
                        cliente.Port = 587; // defino a porta de comunicação
                        cliente.EnableSsl = true; // tipo de segurança SSL
                        
                        //cliente.Timeout = 2000;
                        cliente.UseDefaultCredentials = false;
                        cliente.Credentials = new System.Net.NetworkCredential(email, senha); // chamo minhas credernciais
                        cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
                       
                        MailMessage mail = new MailMessage(); // criar msg
                        
                        mail.Sender = new MailAddress(email, " Sistema TDS"); // configura o email de envio
                        mail.From = new MailAddress(email,"Recuperar Senha:"); // configura o email de envio
                        emailUsuario = dt.Rows[0][4].ToString();
                        mail.To.Add(new MailAddress(emailUsuario, dt.Rows[0][1].ToString())); // email do Usuário
                        mail.Subject = "Lembrar senha";
                        int senhaProvisoria = Random.Next(999999);
                        mail.Body = "Olá "+ dt.Rows[0][1].ToString() + "\n Sua senha é :" + senhaProvisoria ;
                        mail.IsBodyHtml = true; // cria um arquivo HTML
                        mail.Priority = MailPriority.High; // prioridade de envio

                        try
                        {
                            cliente.SendAsync(email, emailUsuario, mail.Subject, mail.Body,1);
                            //cliente.Send(mail);
                            //cliente.Dispose();
                            msg = "email enviado com Sucesso";
                            
                        }
                        catch (Exception ex)
                        {
                            
                            throw new Exception (" Erro ao enviar o email" + ex.Message);
                        }



                    }
                    else
                    {
                        msg = " Usuário não localizado";
                    }
                    



                }
            return msg;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro:" + ex.Message);
            }
 

        }
    }
}
