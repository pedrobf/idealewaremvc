using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IdealeWareMVC.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Nome é obrigatório.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Nome o tamanho máximo deve estar dentro de {1} and {0} caracteres.")]
        public string Name { get; set; }

        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Display(Name = "Quantidade")]
        [Required(ErrorMessage = "Quantidade é obrigatório.")]
        public int Quantity { get; set; }

        [Display(Name = "Preço")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Required(ErrorMessage = "Preço é obrigatório.")]
        [Range(0,99999.9)]
        public decimal Price { get; set; }

        [NotMapped]
        public ICollection<Category> Categories { get; set; } = new List<Category>();

        public Category Category { get; set; }

        [Display(Name = "Categoria")]
        public int IdCategory { get; set; }

        public Product()
        {
        }

        public Product(int id, string name, string description, int quantity, decimal price, Category category)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Quantity = quantity;
            this.Price = price;
            this.Category = category;
        }

        public void AddCategory(Category category)
        {
            Categories.Add(category);
        }
    }
}
