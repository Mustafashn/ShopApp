using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopapp.business.Abstract;
using shopapp.data.Abstract;
using shopapp.entity;

namespace shopapp.business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly IUnitOfWork _unitofwork;

        public CategoryManager(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        public string ErrorMessage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Create(Category entity)
        {
            _unitofwork.Categories.Create(entity);
            _unitofwork.Save();
        }

        public async Task<Category> CreateAsync(Category entity)
        {
            await _unitofwork.Categories.CreateAsync(entity);
            await _unitofwork.SaveAsync();
            return entity;
        }

        public void Delete(Category entity)
        {
            _unitofwork.Categories.Delete(entity);
            _unitofwork.Save();

        }

        public void DeleteFromCategory(int ProductId, int CategoryId)
        {
            _unitofwork.Categories.DeleteFromCategory(ProductId, CategoryId);
            _unitofwork.Save();

        }

        public async Task<List<Category>> GetAll()
        {
            return await _unitofwork.Categories.GetAll();
        }

        public async Task<Category> GetById(int id)
        {
            return await _unitofwork.Categories.GetById(id);
        }

        public Category GetByIdWithProducts(int categoryId)
        {
            return _unitofwork.Categories.GetByIdWithProducts(categoryId);
        }

        public void Update(Category entity)
        {
            _unitofwork.Categories.Update(entity);
            _unitofwork.Save();

        }

        public bool Validation(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}