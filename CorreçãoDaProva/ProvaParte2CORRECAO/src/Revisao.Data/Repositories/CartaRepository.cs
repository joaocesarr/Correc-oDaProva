using Newtonsoft.Json;
using Revisao.Domain.ViewModels;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.Repositories
{
    public class CartaRepository : ICartaRepository
    {
        private readonly string _CartaCaminhoArquivo;


        public CartaRepository()
        {
            _CartaCaminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "FileJsonData", "carta.json");
        }

        public void Adicionar(DocumentosCarta documentosCarta)
        {
            var cartas = LerCartaDoArquivo();
            cartas.Add(documentosCarta);
            EscreverCartaNoArquivo(cartas);
        }


        public IEnumerable<DocumentosCarta> ObterTodos()
        {
            return LerCartaDoArquivo();
        }

        private List<DocumentosCarta> LerCartaDoArquivo()
        {
            if (!System.IO.File.Exists(_CartaCaminhoArquivo))
                return new List<DocumentosCarta>();
            string json = System.IO.File.ReadAllText(_CartaCaminhoArquivo);
            return JsonConvert.DeserializeObject<List<DocumentosCarta>>(json);
        }

        private void EscreverCartaNoArquivo(List<DocumentosCarta> documentosCarta)
        {
            string json = JsonConvert.SerializeObject(documentosCarta);
            System.IO.File.WriteAllText(_CartaCaminhoArquivo, json);
        }
    }
}
