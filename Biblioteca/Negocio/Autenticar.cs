using Biblioteca.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class Autenticar
    {
        public static bool validaSenha(Usuario usuario)
        {
            if(usuario.Senha == "curso")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
