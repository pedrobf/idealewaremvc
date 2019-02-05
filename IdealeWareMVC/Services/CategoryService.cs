using IdealeWareMVC.Data;
using IdealeWareMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdealeWareMVC.Service
{
    public class CategoryService
    {
        private readonly IdealeWareContext _context;

        public CategoryService(IdealeWareContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> FindAllAsync()
        {
            return await _context.Categories.OrderBy(obj => obj.Name).ToListAsync();
        }
    }
}
