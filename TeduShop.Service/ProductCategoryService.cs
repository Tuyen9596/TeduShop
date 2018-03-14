using System;
using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Responsitory;
using TeduShop.Model;

namespace TeduShop.Service
{
    public interface IProductCategoryService
    {
        void Add(ProductCategorie ProductCategory);

        void Update(ProductCategorie ProductCategory);

        void Delete(int id);

        IEnumerable<ProductCategorie> GetAll();

        IEnumerable<ProductCategorie> GetAll(string keyword);

        IEnumerable<ProductCategorie> GetAllByParentId(int parentId);

        ProductCategorie GetById(int id);

        void Save();
    }

    public class ProductCategoryService : IProductCategoryService
    {
        private IProductCategoryRepository _ProductCategoryRepository;
        private IUnitOfWork _unitOfWork;

        public ProductCategoryService(IProductCategoryRepository ProductCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._ProductCategoryRepository = ProductCategoryRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(ProductCategorie ProductCategory)
        {
             _ProductCategoryRepository.Add(ProductCategory);
        }

        public void Delete(int id)
        {
             _ProductCategoryRepository.Delete(id);
        }

        public IEnumerable<ProductCategorie> GetAll()
        {
            return _ProductCategoryRepository.GetAll();
        }

        public IEnumerable<ProductCategorie> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
                return _ProductCategoryRepository.GetMulti(x => x.Name.Contains(keyword) || x.Description.Contains(keyword));
            else
                return _ProductCategoryRepository.GetAll();
        }

        public IEnumerable<ProductCategorie> GetAllByParentId(int parentId)
        {
            return _ProductCategoryRepository.GetMulti(x => x.Status && x.ParentID == parentId);
        }

        public ProductCategorie GetById(int id)
        {
            return _ProductCategoryRepository.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(ProductCategorie ProductCategory)
        {
            _ProductCategoryRepository.Update(ProductCategory);
        }
    }
}