using System.Collections.Generic;
using MovieSite.Domain.Entities;

namespace MovieSite.Data.Repository.Interfaces
{
    public interface IMovieRepository
    {
        List<MovieItem> All();
        MovieItem FindById(int id);
        int Insert(MovieItem entity);
        void Update(MovieItem entity);
    }
}
