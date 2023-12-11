using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDY.Net8.IService
{
    public interface IBaseService<TEntity,TVo> where TEntity : class
    {
       Task<List<TVo>> Query();
    }
}
