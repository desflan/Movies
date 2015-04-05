using Autofac;
using AutoMapper;
using MovieSite.Domain.Entities;
using MovieSite.Services.DTO;

namespace MovieSite.Web.Models
{
    public class Mapping : IStartable
    {
        public void Start()
        {
            Mapper.CreateMap<MovieAddModel, MovieItem>();
            Mapper.CreateMap<MovieItem, MovieEditModel>();
            Mapper.CreateMap<MovieItem, MovieViewModel>();
        }
    }
}