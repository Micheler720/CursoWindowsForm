using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Biblioteca.Modelo.Database
{
    public class Fichario
    {
        public string Diretorio { get; private set; }
        public string Mensagem { get; private set; }
        public bool Status { get; private set; }
        public Fichario(string diretorio)
        {
            Status = true;
            try
            {
                if (!(Directory.Exists(diretorio)))
                {
                    Directory.CreateDirectory(diretorio);
                }
                Diretorio = diretorio;
                Mensagem = "Conectado com sucesso!";
            }
            catch(Exception ex)
            {
                Mensagem = "Conexão com erro" + ex.Message;
                Status = false;
                throw new Exception(ex.Message);
            }
        }
        public void Incluir(int id, string json)
        {
            Status = true;            
            try
            {
                if (File.Exists($"{Diretorio}\\{id}.json"))
                {
                    Mensagem = $"Não é possivel incluir o arquivo já existe o Codigo utilizado. {id}";
                    Status = false;

                }
                else
                {
                    File.WriteAllText($"{Diretorio}\\{id}.json", json);
                    Status = true;
                    Mensagem = $"Dados gravados com sucesso{id}";
                }
            }
            catch(Exception ex)
            {
                Mensagem = "Falha na inclusão" + ex.Message;
                Status = false;
                throw new Exception(ex.Message);
            }
        }
    }
}
