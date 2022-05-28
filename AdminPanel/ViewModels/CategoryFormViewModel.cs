using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AdminPanel.Models;
using Microsoft.AspNetCore.Http;

namespace AdminPanel.ViewModels
{
    public class CategoryFormViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Property> Properites { get; set; }
    }
}
