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
                    Mensagem = $"Já existe um cliente com o codigo: {id}. Deseja atualizar as informações? ";
                    Status = false;

                }
                else
                {
                    IncluirAction(id,json);
                }
            }
            catch(Exception ex)
            {
                Mensagem = "Falha na inclusão" + ex.Message;
                Status = false;
                throw new Exception(ex.Message);
            }
        }
        public void IncluirAction(int id, string json)
        {
            File.Delete($"{Diretorio}\\{id}.json");
            File.WriteAllText($"{Diretorio}\\{id}.json", json);
            Status = true;
            Mensagem = $"Dados gravados com sucesso. Codigo: {id}";
        }
        public string Buscar(string id)
        {
            Status = true;
            try
            {
                if (File.Exists($"{Diretorio}\\{id}.json"))
                {
                    var conteudo = File.ReadAllText($"{Diretorio}\\{id}.json");
                    Status = true;
                    Mensagem = $"Dados gravados com sucesso{id}";
                    return conteudo;
                }
                else
                {
                    Status = false;
                    Mensagem = "Identificador não existente: " + id;
                }

            }catch(Exception ex)
            {
                Status = false;
                Mensagem = "Erro ao buscar conteudo do identificador: " + ex.Message;
            }

            Status = false;
            return "";

        }
        public void Excluir(string id)
        {
            Status = true;
            try
            {
                if (File.Exists($"{Diretorio}\\{id}.json"))
                {
                    File.Delete($"{Diretorio}\\{id}.json");
                    Status = true;
                    Mensagem = $"Dados excluídos com sucesso{id}";
                }
                else
                {
                    Status = false;
                    Mensagem = "Identificador não existente: " + id;
                }

            }
            catch(Exception ex)
            {
                Mensagem = "Falha na exclusão" + ex.Message;
                Status = false;
                throw new Exception(ex.Message);
            }
        }
    }
}
