﻿using Microsoft.AspNetCore.Mvc;
using STUDY.Net8.Model;
using STUDY.Net8.Service;

namespace STUDY.Net8.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet(Name = "GetTest")]
        public async Task<List<UserVo>> Get()
        {
            var userService = new UserService();
            return await userService.query();
        }
    }
}