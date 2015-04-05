using System;
using System.Collections.Generic;
using AutoMapper;
using Autofac;
using MovieSite.Domain.Entities;
using MoviesLibrary;

namespace MovieSite.Data.Mapping
{
    public class MovieItemMapping : IStartable
    {
        public void Start()
        {
            Mapper.CreateMap<MovieData, MovieItem>()
                .ForMember(d => d.Id, m => m.MapFrom(src => src.MovieId))
                .ForMember(d => d.Cast, m => m.MapFrom(src => new List<string>(src.Cast)));

            Mapper.CreateMap<MovieItem, MovieData>()
                .ForMember(d => d.MovieId, m => m.MapFrom(src => src.Id))
                .ForMember(d => d.Cast, m => m.MapFrom(src => src.Cast.ToArray()));
        }
    }
}
