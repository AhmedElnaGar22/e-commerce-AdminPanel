using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AdminPanel.Models;
using Microsoft.AspNetCore.Http;

namespace AdminPanel.ViewModels
{
    public class ProductFormViewModel
    {
        public int Id { get; set; }

        [Required, StringLength(150)]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }

        [Required, StringLength(2000)]
        public string Description { get; set; }



        public IEnumerable<Category> Categories { get; set; }
    }
}
