using AWS_BusinessObjects.Common.Models;
using AWS_BusinessObjects.Entities;
using AWS_Repository.Interface;
using AWS_Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Services.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public void Add(Category category) => categoryRepository.Add(category);
        public void Delete(Guid id) => categoryRepository.Delete(id);
        public List<Category> GetAll() => categoryRepository.GetAll();

        public Category GetById(Guid id) => categoryRepository.GetById(id);

        public void Update(CategoryModel categoryModel) => categoryRepository.Update(categoryModel);
    }
}
