using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
 
namespace CursoWindowsFormsBiblioteca.Classes
{
    public class Cliente
    {
        public class Unit
        {
            [Required(ErrorMessage = "Código de validação é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Código deve ser numérico")]
            [StringLength(6, MinimumLength = 6, ErrorMessage = "Código deve ter 6 dígitos")]
            public string Id { get; set; }
            [Required(ErrorMessage = "Nome é obrigatório")]
            [StringLength(50, ErrorMessage = "Nome deve ter no máximo 50 caracteres")]
            public string Nome { get; set; }
            [Required(ErrorMessage = "Nome da mãe é obrigatório")]
            [StringLength(50, ErrorMessage = "Nome da mãe deve ter no máximo 50 caracteres")]
            public string NomeMae { get; set;}
            [Required(ErrorMessage = "Nome do pai é obrigatório")]
            [StringLength(50, ErrorMessage = "Nome do pai deve ter no máximo 50 caracteres")]
            public string NomePai { get; set; }
            public bool NaoTemPai { get; set; }
            [Required(ErrorMessage = "CPF é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "CPF deve conter apenas números")]
            [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF deve ter 11 dígitos")]
            public string Cpf { get; set;}

            public int Genero { get; set;}
            [Required(ErrorMessage = "CEP é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "CEP deve conter apenas números")]
            [StringLength(8, MinimumLength = 8, ErrorMessage = "CEP deve ter 8 dígitos")]
            public string Cep { get; set;}
            [Required(ErrorMessage = "Logradouro é obrigatório")]
            [StringLength(100, ErrorMessage = "Logradouro deve ter no máximo 100 caracteres")]
            public string Logradouro { get; set;}           
            [StringLength(25, ErrorMessage = "Nome da mãe deve ter no máximo 25 caracteres")]
            public string Bairro { get; set;}
            [Required(ErrorMessage = "Bairro é obrigatório")]
            [StringLength(30, ErrorMessage = "Bairro deve ter no máximo 30 caracteres")]
            public string Cidade { get; set;}
            [Required(ErrorMessage = "Estado é obrigatório")]
            [StringLength(30, ErrorMessage = "Estado deve ter no máximo 30 caracteres")]
            public string Estado { get; set;}
            
            public void ValidaClasse()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new ValidationException(sbrErrors.ToString());
                }
            }
             
            public void ValidaComplemento()
            {
                if(this.NomeMae == this.NomePai)
                {
                    throw new Exception("Nome do pai e da mãe não pode ser iguais.");
                }
                if(this.NomePai == "")
                {
                    throw new Exception("Nome do pai não pode estar vazio quando a propriedade não estiver marcada.");
                }

                bool validaCPF = Cls_Uteis.Valida(this.Cpf);
                if (validaCPF == false)
                {
                    throw new Exception("CPF Inválido");
                }
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
