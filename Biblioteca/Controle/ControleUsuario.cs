using Biblioteca.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class ControleUsuario
    {
        public static object Frm_Login { get; private set; }

        public static bool validaSenhaLogin(string nomeUsuario, string senha)
        {

            Usuario usuario = new Usuario(nomeUsuario, senha);
            return Autenticar.validaSenha(usuario);
        }

    }
}
