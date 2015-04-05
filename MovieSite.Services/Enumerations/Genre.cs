using System.ComponentModel.DataAnnotations;

namespace MovieSite.Services.Enumerations
{
    public enum Genre
    {
        Action,
        Adventure,
        Animation,
        Comedy,
        Crime,
        Disaster,
        Documentary,
        Drama,
        Eastern,
        Erotic,
        Family,
        [Display(Name = "Fan Film")]
        FanFilm,
        Fantasy,
        [Display(Name = "Film Noir")]
        FilmNoir,
        Foreign,
        History,
        Holiday,
        Horror,
        Indie,
        Music,
        Musical,
        Mystery,
        Neonoir,
        [Display(Name = "Road Movie")]
        RoadMovie,
        Romance,
        [Display(Name = "Science Fiction")]
        ScienceFiction,
        Short,
        Sport,
        [Display(Name = "Sporting Event")]
        SportingEvent,
        [Display(Name = "Sports Film")]
        SportsFilm,
        Suspense,
        [Display(Name = "TV Movie")]
        TVMovie,
        Thriller,
        War,
        Western
    }
}
