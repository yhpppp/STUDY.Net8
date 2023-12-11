using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using STUDY.Net8.Model;
using STUDY.Net8.Service;

namespace STUDY.Net8.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class TestController : ControllerBase
    {
        private readonly IMapper _mapper;

        public TestController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet(Name = "GetTest")]
        //public async Task<List<UserVo>> Get()
        //{
        //    var userService = new UserService();
        //    return await userService.query();
        //}
        public async Task<Object> Get()
        {
            var baseService = new BaseService<Role, RoleVo>(_mapper);
            return await baseService.Query();
        }
    }
}
