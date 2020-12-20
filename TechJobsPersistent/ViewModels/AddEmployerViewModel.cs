using System;
using System.ComponentModel.DataAnnotations;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; }

        public AddEmployerViewModel()
        {
        }
    }
}
