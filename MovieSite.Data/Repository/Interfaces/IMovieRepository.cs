using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
