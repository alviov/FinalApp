using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FinalApp.Services.Dto;
using FinalApp.Entities;

namespace FinalApp.Services.Mapper
{
    public class ChelationTherapyMapper : IChelationTherapyMapper
    {
        public ChelationTherapyMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ChelationTherapyData, ChelationTherapyDto>().ReverseMap();
            });
            Mapper = config.CreateMapper();
        }
        public IConfigurationProvider ConfigurationProvider => Mapper.ConfigurationProvider;
        protected IMapper Mapper { get; set; }
        public T Map<T>(object source)
        {
            return Mapper.Map<T>(source);
        }
        public void Map<TSource, TDestination>(TSource source, TDestination destination)
        {
            Mapper.Map(source, destination);
        }


    }
}
