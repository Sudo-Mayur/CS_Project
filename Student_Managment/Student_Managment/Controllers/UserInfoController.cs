using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student_Managment.Models;
using Student_Managment.Services;

namespace Student_Managment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInfoController : ControllerBase
    {
        private readonly IService<UserInfo, int> user;
        public UserInfoController(IService<UserInfo, int> user)
        {
            this.user = user;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var res = user.GetAsync().Result;
            return Ok(res);
        }

        [HttpPost]
        public IActionResult Create(UserInfo info)
        {
            if(ModelState.IsValid)
            {
                var res = user.CreateAsync(info).Result;
                return Ok(res);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}

