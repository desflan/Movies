using System.Collections.Generic;
using AutoMapper;
using MovieSite.Data.Repository.Interfaces;
using MovieSite.Domain.Entities;
using MovieSite.Services.DTO;
using MovieSite.Services.Interfaces;

namespace MovieSite.Services.Services
{
    public class  MovieService : IMovieService
    {
        private readonly IMovieRepository _repository;

        public MovieService(IMovieRepository repository)
        {
            _repository = repository;
        }

        public ICollection<MovieViewModel> List()
        {
            var movies = _repository.All();
            return Mapper.Map<ICollection<MovieViewModel>>(movies);
        }

        public ICollection<MovieViewModel> Search()
        {
            var movies = _repository.All();
            return Mapper.Map<ICollection<MovieViewModel>>(movies);
        }

        public MovieEditModel FindById(int id)
        {
            var movie = _repository.FindById(id);
            return Mapper.Map<MovieEditModel>(movie);
        }

        public int Add(MovieAddModel entity)
        {
            var movie = Mapper.Map<MovieItem>(entity);
            return _repository.Insert(movie);
        }

        public void Update(MovieEditModel entity)
        {
            var movie = Mapper.Map<MovieItem>(entity);
             _repository.Update(movie);
        }
    }
}
