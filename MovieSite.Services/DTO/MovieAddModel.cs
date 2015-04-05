using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AutoMapper;
using Autofac;
using MovieSite.Domain.Entities;

namespace MovieSite.Services.DTO
{
    public class MovieAddModel
    {
        [Required]
        public List<string> Cast { get; set; }
        [Required]
        public string Classification { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public int Rating { get; set; }
        [Required]
        public string ReleaseDate { get; set; }
        [Required]
        public string Title { get; set; }
    }
}
