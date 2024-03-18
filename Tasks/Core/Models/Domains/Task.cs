﻿using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace Tasks.Core.Models.Domains
{
    public class Task
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage ="Pole tytuł jest wymagane.")]
        [Display(Name ="Tytuł")]
        public string Title { get; set; }

        [MaxLength(250)]
        [Required(ErrorMessage = "Pole opis jest wymagane.")]
        [Display(Name = "Opis")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Pole kategoria jest wymagane.")]
        [Display(Name = "Kategoria")]
        public int CategoryId { get; set; }

        [Display(Name = "Termin")]
        public DateTime? Term { get; set; }

        [Display(Name = "Zrealizowane")]
        public bool IsExecute { get; set; }
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
        public Category Category { get; set; }

    }
}
