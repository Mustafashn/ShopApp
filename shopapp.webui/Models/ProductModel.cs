using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using shopapp.entity;

namespace shopapp.webui.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        // [Required(ErrorMessage = "Name is required")]
        // [Display(Prompt = "Enter Product Name")]
        // [StringLength(60, MinimumLength = 5, ErrorMessage = "Name must between 5-60 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Url is required")]
        [Display(Prompt = "Enter Product Url")]
        public string Url { get; set; }

        [Display(Prompt = "Enter Product Price")]
        [Range(1, 20000, ErrorMessage = "Price must positive")]
        public double? Price { get; set; }
        [Required(ErrorMessage = "Description is required")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Description must between 5-100 characters")]
        public string Description { get; set; }
        public bool isApproved { get; set; }
        public bool isHome { get; set; }
        [Display(Prompt = "Enter Product ImageUrl (jpg,jpeg,png)")]
        [Required(ErrorMessage = "ImageUrl is required")]
        public string ImageUrl { get; set; }
        public List<Category> SelectedCategories { get; set; }
    }
}