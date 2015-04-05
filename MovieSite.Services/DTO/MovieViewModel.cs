using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AutoMapper;
using Autofac;
using MovieSite.Domain.Entities;

namespace MovieSite.Services.DTO
{
    public class MovieViewModel
    {
        public List<string> Cast { get; set; }
        public string Classification { get; set; }
        public string Genre { get; set; }
        public int Id { get; set; }
        public int Rating { get; set; }
        public string ReleaseDate { get; set; }
        public string Title { get; set; }
    }
}
