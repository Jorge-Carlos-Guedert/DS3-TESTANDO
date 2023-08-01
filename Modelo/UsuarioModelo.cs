using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    // Objeto usuário
    public class UsuarioModelo
    {
        // atributos aplicados no bd
        public int idusuario;
        public string nome;
        public string senha;
        public string nomeCompleto;
        public string email;
        public string telefoneContato;
        public string whatsapp;
        public string endereco;
        public string ceb;
        public string funcao;
        public int idperfil;


        // construtor da classe modelo usuario
        public UsuarioModelo() {
            nome = null;
            senha = null;
            nomeCompleto = null;
            email = null;
            telefoneContato = null;
            whatsapp = null;
            endereco = null;
            ceb = null;
            funcao = null;
            idperfil = 0;
        }

    }
}
