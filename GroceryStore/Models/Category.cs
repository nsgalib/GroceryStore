using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GroceryStore.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Display(Name = "Category")]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}