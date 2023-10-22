using Revisao.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Interfaces
{
    public interface ICartaRepository
    {
        IEnumerable<DocumentosCarta> ObterTodos();

        void Adicionar(DocumentosCarta documentosCarta);
    }
}
