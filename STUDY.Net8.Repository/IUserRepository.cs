using STUDY.Net8.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDY.Net8.Repository
{
    public interface IUserRepository
    {
        public Task<List<User>> Query();
    }
}
