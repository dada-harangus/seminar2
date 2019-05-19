﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Seminar2.Model
{

    public enum Genre { action, comedy, horror, thriller }
    public enum Watched { yes, no }

    public class Movie



    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [EnumDataType(typeof(Genre))]
        public Genre Genre { get; set; }
        public int Duration { get; set; }
        public int YearRelease { get; set; }
        public string Director { get; set; }
        public DateTime DateAdded { get; set; }
        [Range(1, 10)]
        public int Rating { get; set; }
        [EnumDataType(typeof(Watched))]
        public Watched watched { get; set; }
        public List<Comment> Comments { get; set; }



    }
}
