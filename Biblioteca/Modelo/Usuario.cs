using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Modelo
{
    public class Usuario
    {
        public string NomeUsuario { get; private set; }
        public string Senha { get; private set; }
        /// <summary>
        /// Criar Usuário 
        /// </summary>
        /// <param name="nomeUsuario">Nome do usuário</param>
        /// <param name="senha">Senha</param>
        public Usuario(string nomeUsuario, string senha)
        {
            NomeUsuario = nomeUsuario;
            Senha = senha;
        }
    }
}
