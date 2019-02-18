using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DungApplication.Data.Infrastructure;
using DungApplication.Model.Models;

namespace DungApplication.Data.Repositories
{
    public interface ICategoryRepository:IRepository<Category>
    {
        IEnumerable<Category> GetByAlias(string alias);
    }
    public class CategoryRepository : Repository<Category>,ICategoryRepository
    {
        public CategoryRepository(IDbFactory dbFactory): base(dbFactory)
        {

        }

        public IEnumerable<Category> GetByAlias(string alias)
        {
            return this.DbContext.Categories.Where(x => x.Alias == alias);
        }
    }
}