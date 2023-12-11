using Newtonsoft.Json;
using STUDY.Net8.Model;

namespace STUDY.Net8.Repository
{
    public class UserRepository : IUserRepository
    {
        public async Task<List<User>> Query()
        {
            await Task.CompletedTask;
            string data = "[{\"Id\":17,\"name\":\"Jack\"}]";
            return JsonConvert.DeserializeObject<List<User>>(data) ?? new List<User>();
        }
    }
}
