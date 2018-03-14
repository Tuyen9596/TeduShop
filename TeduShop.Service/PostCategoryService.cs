﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Responsitory;
using TeduShop.Model;

namespace TeduShop.Service
{
    public interface IPostCategoryService : IRepository<PostCategorie>
    {
        void Add(PostCategorie postCategory);

        void Update(PostCategorie postCategory);

        void Delete(PostCategorie postCategory);

        void Delete(int id);

        IEnumerable<PostCategorie> GetAll();

        IEnumerable<PostCategorie> GetAllByParentId(int parentId);

        void GetById(int id);

        void Save();
    }

    public class PostCategoryService : IPostCategoryService
    {
        private IPostCategoryRepository _postCategoryRepository;
        private IUnitOfWork _unitOfWork;

        public PostCategoryService(IPostCategoryRepository postCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._postCategoryRepository = postCategoryRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(PostCategorie postCategory)
        {
            _postCategoryRepository.Add(postCategory);
        }

        public bool CheckContains(Expression<Func<PostCategorie, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public int Count(Expression<Func<PostCategorie, bool>> where)
        {
            throw new NotImplementedException();
        }

        public void Delete(PostCategorie postCategory)
        {
            _postCategoryRepository.Delete(postCategory);
        }

        public void Delete(int id)
        {
            _postCategoryRepository.Delete(id);
        }

        public void DeleteMulti(Expression<Func<PostCategorie, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PostCategorie> GetAll()
        {
            return _postCategoryRepository.GetAll();
        }

        public IQueryable<PostCategorie> GetAll(string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PostCategorie> GetAllByParentId(int parentId)
        {
            return _postCategoryRepository.GetMulti(x => x.Status == true && x.ParentID == parentId);
        }

        public PostCategorie GetById(int id)
        {
            return _postCategoryRepository.GetSingleById(id);
        }

        public IQueryable<PostCategorie> GetMulti(Expression<Func<PostCategorie, bool>> predicate, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<PostCategorie> GetMultiPaging(Expression<Func<PostCategorie, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public PostCategorie GetSingleByCondition(Expression<Func<PostCategorie, bool>> expression, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public PostCategorie GetSingleById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(PostCategorie postCategory)
        {
            _postCategoryRepository.Update(postCategory);
        }

        void IPostCategoryService.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}