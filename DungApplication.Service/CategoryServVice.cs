using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungApplication.Data.Infrastructure;
using DungApplication.Data.Repositories;
using DungApplication.Model.Models;

namespace DungApplication.Service
{
    public interface IProductCategoryService
    {
        Category Add(Category ProductCategory);

        void Update(Category ProductCategory);

        Category Delete(int id);

        IEnumerable<Category> GetAll();

        IEnumerable<Category> GetAll(string keyword);

        IEnumerable<Category> GetAllByParentId(int parentId);

        Category GetById(int id);

        void Save();
    }
    public class CategoryServVice : IProductCategoryService
    {
        
        private ICategoryRepository _ProductCategoryRepository;
        private IUnitOfWork _unitOfWork;

        public CategoryServVice(ICategoryRepository ProductCategoryRepository, IUnitOfWork unitOfWork)
        {
            _ProductCategoryRepository = ProductCategoryRepository;
            _unitOfWork = unitOfWork;

        }


        public Category Add(Category ProductCategory)
        {
            return _ProductCategoryRepository.Add(ProductCategory);
        }

        public Category Delete(int id)
        {
            return _ProductCategoryRepository.Delete(id);
        }

        public IEnumerable<Category> GetAll()
        {
            return _ProductCategoryRepository.GetAll();
        }

        public IEnumerable<Category> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
                return _ProductCategoryRepository.GetMulti(x => x.Name.Contains(keyword) || x.Describe.Contains(keyword));
            else
                return _ProductCategoryRepository.GetAll();

        }

        public IEnumerable<Category> GetAllByParentId(int parentId)
        {
            return _ProductCategoryRepository.GetMulti(x => x.Stat && x.ParentId == parentId);
        }

        public Category GetById(int id)
        {
            return _ProductCategoryRepository.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(Category ProductCategory)
        {
            _ProductCategoryRepository.Update(ProductCategory);
        }
    }
}
