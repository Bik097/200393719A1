﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _200393719A1.Models
{
    public class Reviews
    {
        [Key]
        [Required]
        public int ReviewId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Review { get; set; }
        [Display(Name = "Number Of Stars")]
        [Range(1, 5)]
        public int NumberOfStars { get; set; }
    }
}