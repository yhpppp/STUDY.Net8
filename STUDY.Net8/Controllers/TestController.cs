using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using STUDY.Net8.IService;
using STUDY.Net8.Model;
using STUDY.Net8.Service;

namespace STUDY.Net8.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class TestController : ControllerBase
    {
        private readonly IBaseService<Role, RoleVo> _roleService;

        public TestController(IMapper mapper, IBaseService<Role, RoleVo> roleService)
        {
            _roleService = roleService;
        }

        [HttpGet(Name = "GetTest")]
        //public async Task<List<UserVo>> Get()
        //{
        //    var userService = new UserService();
        //    return await userService.query();
        //}
        public async Task<Object> Get()
        {
            return await _roleService.Query();
        }
    }
}
