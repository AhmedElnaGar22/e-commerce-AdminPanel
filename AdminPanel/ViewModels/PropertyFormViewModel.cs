using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AdminPanel.Models;
using Microsoft.AspNetCore.Http;

namespace AdminPanel.ViewModels
{
    public class PropertyFormViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public IEnumerable<Category> Categories { get; set; }
    }
}
