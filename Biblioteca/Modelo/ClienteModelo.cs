using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Biblioteca.Modelo
{
    /// <summary>
    /// Classe que representa cadastro de Cliente.
    /// </summary>
    public class ClienteModelo
    {
        public class Unit
        {
            [Required(ErrorMessage ="Codígo obrigatório para lançamento de cliente")]
            [Range(0,int.MaxValue,ErrorMessage ="Numero inteiro positivo")]
            public int Id { get; private set; }

            [Required(ErrorMessage = "Impossivel Inserir Cliente sem informação de Cliente.")]
            [StringLength(50,ErrorMessage ="Deve ter no máximo 50 caracteres")]
            public string NomeCliente { get; set; }

            [Required(ErrorMessage ="Impossivel Inserir Cliente sem informação de CPF.")] 
            //[StringLength(14,MinimumLength =14,ErrorMessage ="CPF deve ter 11 digitos")]
            [RegularExpression("([0-9]{3}[.]{1}){2}[0-9]{3}-[0-9]{2}", ErrorMessage = "CPF deve ter 11 digitos")]
            public string Cpf { get; private set; }

            [StringLength(50, ErrorMessage = "Deve ter no máximo 50 caracteres")]
            public string NomePai { get; set; }

            [Required(ErrorMessage ="Nome da mãe é obrigatório.")]
            [StringLength(50,ErrorMessage = "Tem no maxímo 50 caracteres")]
            public string NomeMae { get; set; }

            public bool NaoTemPai { get; set; }

            [Required(ErrorMessage ="Gênero obrigátorio")]

            /// 0 - Masculino 1 - Feminino 2 - Indefinido
            public int Genero { get; set; }

            [Required(ErrorMessage ="CEP obrigátorio")]
            //[StringLength(9,MinimumLength =9, ErrorMessage ="O CEP deverá ter 8 digítos")]
            [RegularExpression("[0-9]{5}-?[0-9]{3}",ErrorMessage = "O CEP deverá ter 8 digítos")]
            public string Cep { get; set; }

            [Required(ErrorMessage ="Logradouro é obrgátorio")]
            [StringLength(100,ErrorMessage ="Maxímo 100 caracteres")]
            public string Logradouro { get; set; }
            public string Complemento { get;  set; }

            [Required(ErrorMessage ="Bairro é obrigatório")]
            [StringLength(50,ErrorMessage ="Maxímo 50 caracteres")]
            public string Bairro { get; set; }

            [Required(ErrorMessage = "Cidade é obrgátorio")]
            [StringLength(100, ErrorMessage = "Maxímo 100 caracteres")]
            public string Cidade { get; set; }

            [Required(ErrorMessage = "Estado é obrgátorio")]
            [StringLength(50, ErrorMessage = "Maxímo 50 caracteres")]
            public string Estado { get; set; }

            [Required(ErrorMessage = "Telefone é obrgátorio")]
            //[StringLength(13,MinimumLength= 13, ErrorMessage = "O Telefone deverá ter 13 caracteres")]
            [RegularExpression("[0-9]{2}[ ]{1}[0-9]{4,5}-{1}[0-9]{4}", ErrorMessage = "O Telefone deverá ter 13 caracteres")]
            public string Telefone { get; set; }

            public string Profissao { get; set; }
            [Required(ErrorMessage = "Renda Familiar é obrgátorio")]
            [RegularExpressionAttribute("[0-9]+")]
            [Range(0,double.MaxValue,ErrorMessage ="Renda Familiar dever ser um número positivo")]
            public double RendaFamiliar { get; set; }
            /// <summary>
            /// Para criação de classe cliente é necessario informar 3 parâmetros
            /// </summary>
            /// <param name="nome">Nome do CLiente</param>
            /// <param name="cpf">CPF</param>
            /// <param name="id">ID</param>
            /// 
            public Unit(int id,string nome, string cpf)
            {
                Id = id;
                NomeCliente = nome;
                Cpf = cpf;
            }
            
        }
        public class List
        {
            public List<Unit> ListUnit { get; set; }

        }

        public static Unit DesSerializedClassUnit(string vJson)
        {
            return JsonConvert.DeserializeObject<Unit>(vJson);
        }
        public static string SerializedClassUnit(Unit unit)
        {
            return JsonConvert.SerializeObject(unit);
        }

    }
}
