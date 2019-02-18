using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungApplication.Data.Infrastructure;
using DungApplication.Data.Repositories;
using DungApplication.Model.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DungApplication.UnitTest.RepositoryTest
{
    [TestClass]
    public class CategoryRepositoryTest
    {
        IDbFactory dbFactory;
        private ICategoryRepository objectRepository;
        private IUnitOfWork unitOfWork;

        [TestInitialize]
        public void Initialize()
        {
            dbFactory=new DbFactory();
            objectRepository = new CategoryRepository(dbFactory);
            unitOfWork=new UnitOfWork(dbFactory);
        }

        [TestMethod]
        public void Category_Repository_GetALL()
        {
           
            var list = objectRepository.GetAll().ToList();
            Assert.AreEqual(1,list.Count);

        }
        
    }
}
