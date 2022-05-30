using DurkayaRecipe.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DurkayaRecipe.WebUI.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Yemek ismi zorunludur!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Ürün ismi 5-50 karakter uzunluğunda olmalıdır!")]
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string Url { get; set; }
        public List<Category> SelectedCategories { get; set; }
    }
}
