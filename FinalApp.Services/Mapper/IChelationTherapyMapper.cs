using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;


namespace FinalApp.Services.Mapper
{
    public interface IChelationTherapyMapper
    {
        IConfigurationProvider ConfigurationProvider { get; }
        T Map<T>(object source);
        void Map<TSource, TDestination>(TSource source, TDestination destination);
    }
}
