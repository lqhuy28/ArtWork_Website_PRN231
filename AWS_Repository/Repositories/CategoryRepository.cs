using AWS_BusinessObjects.Common.Interfaces;
using AWS_BusinessObjects.Common.Models;
using AWS_BusinessObjects.Entities;
using AWS_DAO;
using AWS_Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Repository.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly CategoryDAO _categoryDAO;
        public CategoryRepository(CategoryDAO categoryDAO)
        {
            _categoryDAO = categoryDAO;
        }
        public void Add(Category category)  => _categoryDAO.Add(category);

        public void Delete(Guid id) => _categoryDAO.Delete(id);

        public List<Category> GetAll() => _categoryDAO.GetAll();
        public Category GetById(Guid id) => _categoryDAO.GetById(id);

        public void Update(CategoryModel category) => _categoryDAO.Update(category);
    }
}
