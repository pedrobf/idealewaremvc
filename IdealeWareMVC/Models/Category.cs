using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdealeWareMVC.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "{0} é obrigatório.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "{0} deve ter tamanho máximo de {2} e mínimo {1} caracteres.")]
        public string Name { get; set; }

        [Display(Name = "Descrição")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "{0} deve ter tamanho máximo de {2} e mínimo {1} caracteres.")]
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();

        public Category()
        {
        }

        public Category(int id, string name, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
    }
}
