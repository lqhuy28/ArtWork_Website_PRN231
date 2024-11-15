using AWS_BusinessObjects.Common.Interfaces;
using AWS_BusinessObjects.Common.Models;
using AWS_BusinessObjects.Entities;
using AWS_DAO.Common.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO
{
    public class CategoryDAO
    {
        private readonly IApplicationDbContext _context;
        public CategoryDAO(IApplicationDbContext context)
        {
            _context = context;
        }

        // get all Interact, check isDeleted = false, sort by Created
        public List<Category> GetAll()
        {
            try
            {
                List<Category> categories
                    = (List<Category>)_context.Get<Category>().Where(x => x.IsDeleted==false).OrderByDescending(x => x.Created) 
                    .Include(o=>o.ArtWorks)
                    .ToList();
                return categories;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // get Interact by id
        public Category GetById(Guid id)
        {
            try
            {
                return _context.Get<Category>().Where(o => o.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // add Interact
        public void Add(Category category)
        {
            try
            {
                _context.Get<Category>().Add(category);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // update Interact
        public void Update(CategoryModel categoryModel)
        {
            try
            {
                var Category = _context.Get<Category>().FirstOrDefault(x => x.Id == categoryModel.Id);
                if (Category == null)
                {
                    throw new NotFoundException();
                }
                Category.CategoryName = categoryModel.CategoryName;
                Category.Description = categoryModel.Description;
                Category.LastModified = DateTime.Now;

                _context.Get<Category>().Update(Category);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // delete Interact, isDeleted = true
        public void Delete(Guid id)
        {
            try
            {
                var category = _context.Get<Category>().FirstOrDefault(x => x.Id == id);
                if (category == null)
                {
                    throw new NotFoundException();
                }
                category.IsDeleted = true;
                _context.Get<Category>().Update(category);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
