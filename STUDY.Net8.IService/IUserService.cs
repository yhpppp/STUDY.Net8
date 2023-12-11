using STUDY.Net8.Model;

namespace STUDY.Net8.IService
{
    public interface IUserService
    {
        Task<List<UserVo>> Query();
    }
}
