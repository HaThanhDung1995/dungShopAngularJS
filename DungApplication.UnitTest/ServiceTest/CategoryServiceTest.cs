using System.Collections.Generic;
using System.Linq;
using DungApplication.Data.Infrastructure;
using DungApplication.Data.Repositories;
using DungApplication.Model.Models;
using DungApplication.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DungApplication.UnitTest.ServiceTest
{
    [TestClass]
    public class CategoryServiceTest
    {
        private Mock<ICategoryRepository> _mockRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private CategoryServVice _categoryServVice;
        private List<Category> list;
        [TestInitialize]
        public void Initialize()
        {
            _mockRepository=new Mock<ICategoryRepository>();
            _mockUnitOfWork=new Mock<IUnitOfWork>();
            _categoryServVice=new CategoryServVice(_mockRepository.Object,_mockUnitOfWork.Object);
            list=new List<Category>()
            {
                new Category(){Id=1,Name="DM1",Stat = true},
                new Category(){Id=2,Name="DM2",Stat = false},
                new Category(){Id=3,Name="DM3",Stat = true},
            };
        }
        [TestMethod]
        public void Category_Service_GetAll()
        {
            _mockRepository.Setup(m => m.GetAll(null)).Returns(list);
            var result = _categoryServVice.GetAll() as List<Category>;
            Assert.IsNotNull(result);
            Assert.AreEqual(3,result.Count);
        }
        [TestMethod]
        public void Category_Service_Create()
        {
           Category category = new Category();
            int id = 1;
            category.Name = "Test";
            category.Alias = "test";
            category.Stat = true;
            _mockRepository.Setup(m => m.Add(category)).Returns((Category p) =>
            {
                p.Id = 2;
                return p;
            });
            var result=_categoryServVice.Add(category);
            Assert.IsNotNull(result);
            Assert.AreEqual(1,result.Id);

        }
    }
}