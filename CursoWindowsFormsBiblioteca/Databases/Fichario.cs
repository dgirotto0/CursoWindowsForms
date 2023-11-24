using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CursoWindowsFormsBiblioteca.Databases;

namespace CursoWindowsFormsBiblioteca.Databases
{
    public class Fichario
    {
        public string diretorio;
        public string mensagem;
        public bool status;

        public Fichario(string Diretorio)
        {
            status = true;
            try
            {
                if (!(Directory.Exists(Diretorio)))
                {
                    Directory.CreateDirectory(Diretorio);
                }
                diretorio = Diretorio;
                mensagem = "Cadastrado";
            }
            catch
            {
                status = false;
                mensagem = "Não cadastrado";
            }            
        }
        public void Incluir(string Id, string jsonUnit)
        {
            status = true;
            try
            {
                if(File.Exists(diretorio + "\\" + Id + ".json"))
                {
                    status = false;
                    mensagem = "Código já cadastrado";
                }
                else
                {
                    File.WriteAllText(diretorio + "\\" + Id + ".json", jsonUnit);
                    status = true;
                    mensagem = "Cadastrado com sucesso";
                }
            }
            catch(Exception ex) 
            {
                status = false;
                mensagem = "Conexão com o fichário com o erro: " + ex.Message;
            }
        }
        public string Buscar(string Id)
        {
            status = true;
            try
            {
                if (!(File.Exists(diretorio + "\\" + Id + ".json")))
                {
                    status = false;
                    mensagem = "Código " + Id + "não encontrado.";
                }
                else
                {
                    string conteudo = File.ReadAllText(diretorio + "\\" + Id + ".json");
                    status = true;
                    mensagem = "Cadastrado com sucesso";
                    return conteudo;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Id não encontrado. " + ex.Message;
            }
            return "";
        }

        public void Apagar(string Id)
        {
            status = true;
            try
            {
                if (!(File.Exists(diretorio + "\\" + Id + ".json")))
                {
                    status = false;
                    mensagem = "Código " + Id + "não encontrado.";
                }
                else
                {
                   File.Delete(diretorio + "\\" + Id + ".json");
                    status = true;
                    mensagem = "Excluído com sucesso o Id: " + Id;
                    
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Id não encontrado. " + ex.Message;
            }           
        }

        public void Alterar(string Id, string jsonUnit)
        {
            status = true;
            try
            {
                if (!(File.Exists(diretorio + "\\" + Id + ".json"))) 
                {
                    status = false;
                    mensagem = "Alteração não permitida. Id: " + Id + " não existe.";
                }
                else
                {
                    File.Delete(diretorio + "\\" + Id + ".json");
                    File.WriteAllText(diretorio + "\\" + Id + ".json", jsonUnit);
                    status = true;
                    mensagem = "Alterado com sucesso.";
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com o fichário com o erro: " + ex.Message;
            }
        }

        public List<string> BuscarTodos()
        {
            status = true;
            List<string> List = new List<string>();
            try
            {
                var Arquivos = Directory.GetFiles(diretorio, "*.json");
                for (int i = 0; i <= Arquivos.Length - 1; i++)
                {
                    string conteudo = File.ReadAllText(Arquivos[i]);
                    List.Add(conteudo);
                }
                return List;
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o conteúdo do identificador: " + ex.Message;
            }
            return List;
        }
    }
}
