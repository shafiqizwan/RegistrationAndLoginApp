using Microsoft.AspNetCore.Mvc;
using RegistrationAndLoginApp.Models;
using RegistrationAndLoginApp.Services;

namespace RegistrationAndLoginApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult ProcessLogin(UserModel userModel)
        {
            //if (userModel.UserName == "1111" && userModel.Password == "1111")
            SecurityService securityService = new SecurityService();

            if (securityService.isValid(userModel)) 
            {
                return View("LoginSuccess", userModel);
            }
            else
            {
                return View("LoginFailure", userModel);
            }
            
        }
    }
}
