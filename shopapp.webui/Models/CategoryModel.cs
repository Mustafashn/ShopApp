using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using shopapp.entity;

namespace shopapp.webui.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [Display(Prompt = "Enter Category Name")]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "Name must between 4-30 characters")]
        public string Name { get; set; }
        [Display(Prompt = "Enter Category Url")]
        [Required(ErrorMessage = "Url is required")]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "Url must between 4-30 characters")]
        public string Url { get; set; }
        public List<Product> Products { get; set; }

    }
}