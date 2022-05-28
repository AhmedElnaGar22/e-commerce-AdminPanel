using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdminPanel.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required, MaxLength(150)]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }

        [Required, MaxLength(2000)]
        public string Description { get; set; }

        public byte[] Photo { get; set; }


        public ICollection<Category> Categories { get; set; }
    }
}
