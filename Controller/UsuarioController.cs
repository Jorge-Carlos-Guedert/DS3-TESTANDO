using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Modelo;
using System.Data;

namespace Controller
{

    public class UsuarioController
    {// instanciei o objeto conexao
        Conexao con = new Conexao();
        // criando o metodo de cadastrar usuario
        public bool cadastrar(UsuarioModelo usuario) // passo o objeto pelo parametro
        {// declaro a variavel da resposta da query
            bool resultado = false;
            string sql = " insert into usuario(nome,senha,nomeCompleto,email,telefoneContato,whatsapp,endereco,ceb,funcao,id_perfil) values('" + usuario.nome + "','" + usuario.senha+ "','" +usuario.nomeCompleto+"" +
                "','"+ usuario.email+"','"+ usuario.telefoneContato+"','"+usuario.whatsapp+"','"+usuario.endereco+"','"+usuario.ceb+"','"+usuario.funcao+"','"+usuario.idperfil+"')";
            // chamando minha conexao
            MySqlConnection sqlCon = con.getConexao();
            sqlCon.Open();// abrir o banco
            MySqlCommand cmd = new MySqlCommand(sql, sqlCon);
            if(cmd.ExecuteNonQuery() >= 1)// execute o comendo Sql
            resultado = true;
            sqlCon.Close();// fecho a conexao 
            return resultado; // retorno valor
        }
        // criando método exibir usuario
        public DataTable OberDados(string sql)
        {
            // crio uma nova tabela de dados
            DataTable dt = new DataTable();
            MySqlConnection conn = con.getConexao();
            conn.Open(); // abre banco de dados
            // preparo o commando sql
            MySqlCommand sqlCon = new MySqlCommand(sql, conn);
            //tipo de instrução de texto
            sqlCon.CommandType=System.Data.CommandType.Text;
            sqlCon.CommandText=sql;
            MySqlDataAdapter dados = new MySqlDataAdapter(sqlCon);
            dados.Fill(dt);// montar a tabela de dados
            conn.Close();
            return dt;// retorna a tabela de dados
        }

        public bool excluir(int codigo)
        {
            bool resultado = false;
            string sql = "DELETE FROM usuario where idusuario=" + codigo;
            MySqlConnection sqlCon = con.getConexao();
            sqlCon.Open();
            MySqlCommand cmd = new MySqlCommand(sql, sqlCon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            if (cmd.ExecuteNonQuery() >= 1)
                resultado = true;
            sqlCon.Close();
            return resultado;

        }

        public bool editar(UsuarioModelo us)
        {
            bool resultado = false;
            string sql = "UPDATE usuario set nome=@nome, senha=@senha, id_perfil=@perfil where idusuario=@id";
            MySqlConnection sqlCon = con.getConexao();
            sqlCon.Open();
            MySqlCommand cmd = new MySqlCommand(sql, sqlCon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            // substituindo a variavel @___ pelo conteudo do objeto
            cmd.Parameters.AddWithValue("@nome", us.nome);
            cmd.Parameters.AddWithValue("@senha", us.senha);
            cmd.Parameters.AddWithValue("@id", us.idusuario);
            cmd.Parameters.AddWithValue("@perfil", us.idperfil);
            if (cmd.ExecuteNonQuery() >= 1)
                resultado = true;
            sqlCon.Close();
            return resultado;


        }


        //metodo para carregar o usuario

        public UsuarioModelo CarregaUsuario(int codigo)
        {
            UsuarioModelo us = new UsuarioModelo();
            MySqlConnection sqlCon = con.getConexao();
            sqlCon.Open();
            string sql = "SELECT * from usuario where idusuario=@id";
            MySqlCommand cmd = new MySqlCommand(@sql, sqlCon);
            cmd.Parameters.AddWithValue("@id", codigo); // substituo o valor do código
            MySqlDataReader registro = cmd.ExecuteReader(); //leia os dados da consulta
            if (registro.HasRows)// existe linha de reagistro
            {
                registro.Read(); // leia o registro
                // gravando as informações no modelo usuario
                us.nome = registro["nome"].ToString();
                us.senha = registro["senha"].ToString();
                us.idusuario = Convert.ToInt32(registro["idusuario"]);
                us.idperfil = Convert.ToInt32(registro["id_perfil"]);
            }
            sqlCon.Close();
            return us;
        }

        // finaliza o metodo

        public int logar(UsuarioModelo us)
        {
            
            int registro; // retorna o numero de registros

            string sql = "SELECT idusuario from usuario  where nome=@usuario and senha=@senha";
            MySqlConnection sqlCon = con.getConexao();
            sqlCon.Open();
            MySqlCommand command = new MySqlCommand(sql, sqlCon);
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = sql;
            command.Parameters.AddWithValue("@usuario", us.nome);
            command.Parameters.AddWithValue("@senha", us.senha);
            registro = Convert.ToInt32(command.ExecuteScalar()); // retorna quantidade de registros encontrados

            return registro; // devolvo o idusuario encontrado no banco
        }
    }
}
