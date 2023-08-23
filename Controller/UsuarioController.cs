using System;
using MySql.Data.MySqlClient;
using Modelo;
using System.Data;
using PdfSharp.Drawing;// para desenhar
using PdfSharp.Pdf; // para conversão 
using System.Diagnostics;

namespace Controller
{

    public class UsuarioController
    {// instanciei o objeto conexao
        Conexao con = new Conexao();
        // criando o metodo de cadastrar usuario
        public bool cadastrar(UsuarioModelo usuario) // passo o objeto pelo parametro
        {// declaro a variavel da resposta da query
            bool resultado = false;
            string sql = " insert into usuario(nome,senha,nomeCompleto,email,telefoneContato,whatsapp,endereco,ceb,funcao,id_perfil) values('" + usuario.nome + "','" + con.getMD5Hash(usuario.senha)+ "','" +usuario.nomeCompleto+"" +
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
            string sql = "UPDATE usuario set nome=@nome, senha=@senha, id_perfil=@perfil, email=@email where idusuario=@id";
            MySqlConnection sqlCon = con.getConexao();
            sqlCon.Open();
            MySqlCommand cmd = new MySqlCommand(sql, sqlCon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            // substituindo a variavel @___ pelo conteudo do objeto
            cmd.Parameters.AddWithValue("@nome", us.nome);
            cmd.Parameters.AddWithValue("@senha", con.getMD5Hash(us.senha));
            cmd.Parameters.AddWithValue("@id", us.idusuario);
            cmd.Parameters.AddWithValue("@perfil", us.idperfil);
            cmd.Parameters.AddWithValue("@email", us.email);
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
                us.email = registro["email"].ToString();
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
            command.Parameters.AddWithValue("@senha", con.getMD5Hash(us.senha));
            registro = Convert.ToInt32(command.ExecuteScalar()); // retorna quantidade de registros encontrados

            return registro; // devolvo o idusuario encontrado no banco
        }

        public void gerarPdf(string sql)
        {
           // chamo minha conexão mysql
            MySqlConnection SqlCon = con.getConexao();
            // preparo o comando sql
            UsuarioModelo us = new UsuarioModelo();
            MySqlCommand cmd = new MySqlCommand(sql, SqlCon);

            MySqlDataAdapter dados; // prepara os dados

            DataSet ds = new DataSet();

            try // teste de consulta
            {
                int i = 0; // registro
                int ypoint = 0; // espaço do conteudo
                
                SqlCon.Open(); // abro a conexão
                dados = new MySqlDataAdapter(cmd); // recuperando as informações
                dados.Fill(ds); //  Carrega as informações carregadas
                PdfDocument pdf = new PdfDocument();
                // chamo a instancia do PDF
                pdf.Info.Title = "Listar Usuário";
                PdfPage page = pdf.AddPage();// gera uma nova página
                XGraphics grafic = XGraphics.FromPdfPage(page);
                XFont font = new XFont("arial", 12, XFontStyle.Regular); // defino a fonte e o tamanho
                ypoint = ypoint + 75;

                grafic.DrawString(ds.Tables[0].Columns[0].ColumnName, font, XBrushes.Black, new XRect(20, ypoint, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                grafic.DrawString(ds.Tables[0].Columns[1].ColumnName, font, XBrushes.Black, new XRect(120, ypoint, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                grafic.DrawString(ds.Tables[0].Columns[10].ColumnName, font, XBrushes.Black, new XRect(220, ypoint, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                ypoint = ypoint + 40;

                for (  i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    // guarde no objeto nome o resultado da coluna 
                    us.idusuario = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0].ToString());
                    us.nome = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    us.idperfil = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[10].ToString());
                    grafic.DrawString(us.idusuario.ToString(),font,XBrushes.Black,new XRect(40, ypoint, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    grafic.DrawString(us.nome,font,XBrushes.Black,new XRect(100, ypoint, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    grafic.DrawString(us.idperfil.ToString(),font,XBrushes.Black,new XRect(220, ypoint, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    ypoint = ypoint + 25; // nova posição
                }

                string pdffilename = "Listar Usuário.pdf";

                pdf.Save(pdffilename);

                Process.Start(pdffilename);
                
            } catch(Exception ex)
            {
                throw new ApplicationException(ex.ToString());
            }

        }
    }
}
