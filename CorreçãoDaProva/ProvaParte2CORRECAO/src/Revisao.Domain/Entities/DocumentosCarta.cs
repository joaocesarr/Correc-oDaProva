using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Revisao.Domain.ViewModels
{
    public class DocumentosCarta
    {
        public DocumentosCarta(string nome, string rua, int numero, string bairro, string cidade, string estado, int idade, string texto)
        {
            Nome = nome;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Idade = idade;
            Texto = texto;
        }
        
        [MinLength(3, ErrorMessage = "Minimo 3 Caracteres.")]
        [MaxLength(255, ErrorMessage = "Maximo 255 Caracteres.")]
        [Required(ErrorMessage = "Nome Obrigatorio.")]
        public string Nome { get; private set; }

        [Required(ErrorMessage = "Rua Obrigatoria.")]
        public string Rua { get; private set; }

        [Required(ErrorMessage = "Numero Civico Obrigatorio.")]
        public int Numero { get; private set; }

        [Required(ErrorMessage = "Bairro Obrigatorio.")]
        public string Bairro { get; private set; }

        [Required(ErrorMessage = "Cidade Obrigatoria.")]
        public string Cidade { get; private set; }

        [Required(ErrorMessage = "Estado Obrigatorio.")]
        public string Estado { get; private set; }

        [Required(ErrorMessage = "Idade Obrigatoria.")]
        [Range(0, 15)]
        public int Idade { get; private set; }

        [MinLength(1, ErrorMessage = "Minimo 1 Caracteres.")]
        [MaxLength(500, ErrorMessage = "Maximo 500 Caracteres.")]
        [Required(ErrorMessage = "Texto Obrigatorio.")]
        public string Texto { get; private set; }

    }
}
