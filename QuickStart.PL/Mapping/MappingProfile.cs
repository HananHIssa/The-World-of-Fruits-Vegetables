using AutoMapper;
using QuickStart.DAL.Data.Models;
using QuickStart.PL.Areas.Dashboard.ViewModels;
namespace QuickStart.PL.Mapping
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<ServicesFormVm, Services>().ReverseMap();
			CreateMap<Services, vmService>().ReverseMap();
			CreateMap<Services, ServiceDetailsvm>().ReverseMap();
			CreateMap<EditViewModel, Services>().ReverseMap();

			CreateMap<PortfolioFormVm, Portfolio>().ReverseMap();
			CreateMap<Portfolio, vmPortfolio>().ReverseMap();
			CreateMap<Portfolio, PortfolioeDetailsvm>().ReverseMap();

            CreateMap<ItemsFormVm, Item>().ReverseMap();
            CreateMap<Item, vmItem>().ReverseMap();
            CreateMap<Item, ItemDetailsvm>().ReverseMap();

           CreateMap<ProductFormVm, Product>().ReverseMap();
            CreateMap<Product, vmProduct>().ReverseMap();
           CreateMap<Product, ProductDetailsvm>().ReverseMap();

			CreateMap<CatagoryFormVm, Catagory>().ReverseMap();
			CreateMap<Product, vmCatagory>().ReverseMap();
			CreateMap<Catagory, CatagoryDetailsvm>().ReverseMap();
		}
	}
}
