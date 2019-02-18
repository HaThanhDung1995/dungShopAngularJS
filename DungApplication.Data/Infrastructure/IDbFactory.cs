using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungApplication.Model.Models;

namespace DungApplication.Data.Infrastructure
{
    public interface IDbFactory:IDisposable
    {
        DataContext Init();
    }
}
