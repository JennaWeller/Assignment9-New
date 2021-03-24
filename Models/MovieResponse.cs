﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Assignment3.Views.Home;

namespace Assignment3.Models
{
    public class MovieResponse
    {   //make everything but edited, lent and notes required (validation criteria)

        [Key]
        public int MovieId { get; set; }
        [Required(ErrorMessage = "Error:Please enter a category")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Error:Please enter a title")]
        [MovieValidation]
        public string Title { get; set; }
        [Required(ErrorMessage = "Error:Please enter a year")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Error:Please enter a director")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Error:Please enter a rating")]
        public string Rating { get; set; }
        //boolean since it is true or false
        public Boolean? Edited { get; set; }
        public string Lent { get; set; }
        [StringLength(25)]
        public string Notes { get; set; }
    }
}
