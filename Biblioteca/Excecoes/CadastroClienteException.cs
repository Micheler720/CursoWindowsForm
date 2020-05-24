using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Excecoes
{
    class CadastroClienteException : Exception
    {
        public CadastroClienteException() { }
        public CadastroClienteException(string message)
            : base(message)
        { }
        public CadastroClienteException(string message, Exception e)
            : base(message, e)
        {
        }
    }
}
