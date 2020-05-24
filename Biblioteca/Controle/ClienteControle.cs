using Biblioteca.Modelo;
using Biblioteca.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Controle
{
    public class ClienteControle
    {

        public void ValidaCliente(ClienteModelo.Unit cliente)
        {
            var ClienteNegocio = new ClienteNegocio();
            if (!ClienteNegocio.validaCliente(cliente))
            {

            };
        }
    }
}
