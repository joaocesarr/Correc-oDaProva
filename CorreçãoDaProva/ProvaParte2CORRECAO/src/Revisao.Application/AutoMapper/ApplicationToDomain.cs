using AutoMapper;
using Revisao.Domain.ViewModels;
using Revisao.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.AutoMapper
{
	public class ApplicationToDomain : Profile
	{
		public ApplicationToDomain()
		{

			CreateMap<CartaViewModel, DocumentosCarta>()
			   .ConstructUsing(q => new DocumentosCarta(q.Nome, q.Rua, q.Numero, q.Bairro, q.Cidade, q.Estado, q.Idade, q.Texto));

			CreateMap<NovaCartaViewModel, DocumentosCarta>()
			   .ConstructUsing(q => new DocumentosCarta(q.Nome, q.Rua, q.Numero, q.Bairro, q.Cidade, q.Estado, q.Idade, q.Texto));

		}
	}
}
