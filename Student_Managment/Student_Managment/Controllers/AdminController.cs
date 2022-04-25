using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Student_Managment.Models;
using Student_Managment.Services;

namespace Student_Managment.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly AuthService _authService;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;
        public AdminController(AuthService _authService, RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            this._authService = _authService;
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

       // [Authorize(Roles = "Admin")]
        [HttpPost]
        [ActionName("create")]
        public async Task<IActionResult> Create(RegisterUser registerUser)
        {
            if (ModelState.IsValid)
            {
                var response = await _authService.RegisterNewUserAsync(registerUser);

                return Ok(response.Message);
            }
            return BadRequest(ModelState);
        }


        [HttpPost]
        [ActionName("login")]
        public async Task<IActionResult> Login(LoginUser inputModel)
        {
            if (ModelState.IsValid)
            {
                var token = await _authService.AuthenticateUserAsync(inputModel);
                if (token == null)
                {
                    return Unauthorized("The Authentication Failed");
                }
                var ResponseData = new ResponseData()
                {
                    Message = token
                };

                return Ok(ResponseData);
            }
            return BadRequest(ModelState);
        }
    }
}



//dotnet ef migrations add firstMigration -c Student_Managment.Models.SecurityStudentMarksContext
//dotnet ef database update -c Student_Managment.Models.SecurityStudentMarksContext

