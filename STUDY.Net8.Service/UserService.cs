using STUDY.Net8.IService;
using STUDY.Net8.Model;
using STUDY.Net8.Repository;

namespace STUDY.Net8.Service
{
    public class UserService : IUserService
    {
        public async Task<List<UserVo>> Query()
        {
            var userRepo = new UserRepository();
            var user = await userRepo.Query();
            return user.Select(u => new UserVo() { UserName = u.Name }).ToList();
        }
    }
}
