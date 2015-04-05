using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieSite.Services.DTO;

namespace MovieSite.Services.Interfaces
{
    public interface IMovieService
    {
        ICollection<MovieViewModel> List();
        ICollection<MovieViewModel> Search();
        MovieEditModel FindById(int id);
        int Add(MovieAddModel entity);
        void Update(MovieEditModel entity);
    }
}
