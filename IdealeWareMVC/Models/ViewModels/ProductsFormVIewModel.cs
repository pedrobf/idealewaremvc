using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdealeWareMVC.Models.ViewModels
{
    public class ProductsFormViewModel
    {
        public Product Product { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
