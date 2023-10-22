using AutoMapper;
using Revisao.Application.ViewModels;
using Revisao.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.AutoMapper
{
	public class DomainToApplication : Profile
	{
		public DomainToApplication()
		{
			CreateMap<DocumentosCarta, CartaViewModel>();
		}
	}
}