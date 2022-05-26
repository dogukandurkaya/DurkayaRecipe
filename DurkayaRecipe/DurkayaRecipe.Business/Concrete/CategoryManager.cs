﻿using DurkayaRecipe.Business.Abstract;
using DurkayaRecipe.Data.Abstract;
using DurkayaRecipe.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurkayaRecipe.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public void Create(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Create(Category entity, int[] categoryIds)
        {
            _categoryRepository.Create(entity, categoryIds);

        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Category GetByIdWithCategories(int id)
        {
            return _categoryRepository.GetByIdWithCategories(id);
        }

        public Category GetByIdWithCategories(int? id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity, int[] categoryIds)
        {
            _categoryRepository.Update(entity, categoryIds);
        }
    }
}
