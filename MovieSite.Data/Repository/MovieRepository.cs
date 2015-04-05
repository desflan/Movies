using System.Collections.Generic;
using AutoMapper;
using MovieSite.Data.Infrastructure;
using MovieSite.Data.Repository.Interfaces;
using MovieSite.Domain.Entities;
using MoviesLibrary;

namespace MovieSite.Data.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieDataSource _movieDataRepository;
        private readonly IKaching _cache;
        private const string Movies = "MoviesRepository_MovieItems";

        public MovieRepository(MovieDataSource movieDataSource, IKaching cache)
        {
            _movieDataRepository = movieDataSource;
            _cache = cache;
        }

        public List<MovieItem> All()
        {
            if (!_cache.Exists(Movies))
            {
                var movies = Mapper.Map<List<MovieItem>>(_movieDataRepository.GetAllData());
                _cache.Add(movies, Movies);
                return movies;
            }
            return _cache.Get<List<MovieItem>>(Movies);
        }

        public MovieItem FindById(int id)
        {
            return Mapper.Map<MovieItem>(_movieDataRepository.GetDataById(id));
        }

        public int Insert(MovieItem entity)
        {
            var movie = Mapper.Map<MovieData>(entity);
            return _movieDataRepository.Create(movie);
        }

        public void Update(MovieItem entity)
        {
            var movie = Mapper.Map<MovieData>(entity);
            _movieDataRepository.Update(movie); 
        }
    }
}
