using AutoMapper;
using Revisao.Domain.ViewModels;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Services
{
    public class CartaService : ICartaService
    {
        private readonly ICartaRepository _cartaRepository;
        private IMapper _mapper;

        public CartaService(ICartaRepository cartaRepository, IMapper mapper)
        {
            _cartaRepository = cartaRepository;
            _mapper = mapper;
        }

        public void Adicionar(NovaCartaViewModel novaCartaViewModel)
        {
            var novaCarta = _mapper.Map<DocumentosCarta>(novaCartaViewModel);
            _cartaRepository.Adicionar(novaCarta);

        }

        public IEnumerable<CartaViewModel> ObterTodos()
        {
            return _mapper.Map<IEnumerable<CartaViewModel>>(_cartaRepository.ObterTodos());
        }
    }
}
