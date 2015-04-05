using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AutoMapper;
using Autofac;
using MovieSite.Domain.Entities;

namespace MovieSite.Services.DTO
{
    public class MovieEditModel : MovieAddModel
    {
        [Required]
        public int Id { get; set; }
    }
}
