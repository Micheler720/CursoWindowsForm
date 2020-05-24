using Biblioteca.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Biblioteca.Excecoes;

namespace Biblioteca.Negocio
{
    internal class ClienteNegocio
    {
        public bool validaCliente(ClienteModelo.Unit cliente)
        {
            if (!Cls_Uteis.ValidaCPF(cliente.Cpf))
            {
                throw new CadastroClienteException("CPF inválido. Verifique");
            }
            
            if (cliente.NaoTemPai == false)
            {
                if(cliente.NomePai == "")
                {
                    throw new CadastroClienteException("Não é permitido que nome do pai seja vazio. Caso não exista marque a opção 'Pai desconhecido.'");
                }
                if (cliente.NomePai == cliente.NomeMae)
                {
                    throw new CadastroClienteException("Não é permitido nome de pai igual nome da mãe");
                }
            }
            else
            {
                cliente.NomePai = "";
            }
            return true;

        }

        
    }
}
