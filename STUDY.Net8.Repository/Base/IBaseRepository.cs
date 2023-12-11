using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDY.Net8.Repository.Base
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        public Task<List<TEntity>> Query();
    }
}
