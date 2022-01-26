using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication13.Models;
using WebApplication13.ViewModels;
using WebApplication13.Identity;
using System.Web.Helpers;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace WebApplication13.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterViewModel K)
        {
            if(ModelState.IsValid)
            {
                //register
                var appDbContext = new ApplicationDbContext();
                var userStore = new ApplicationUserStore(appDbContext);
                var userManager = new ApplicationUserManager(userStore);
                var passwordHash = Crypto.HashPassword(K.Password);
                var user = new ApplicationUser() { Email = K.Email, UserName = K.UserName, PasswordHash = K.Password, PhoneNumber = K.Mobile };
               IdentityResult result = userManager.Create(user);

                if(result.Succeeded)
                {
                    //role
                    //userManager.AddToRole(user.Id, "Customer");

                    //login
                    var authenticationManager = HttpContext.GetOwinContext().Authentication;
                    var userIdentity = userManager.CreateIdentity(user,DefaultAuthenticationTypes.ApplicationCookie);
                    authenticationManager.SignIn(new AuthenticationProperties(), userIdentity);
                }
                return RedirectToAction("Index","Home");
            }
            else
            {
                ModelState.AddModelError("My Error", "Invalid Data");
                return View();

            }
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModal A)
        {
            var appDbContext = new ApplicationDbContext();
            var userStore = new ApplicationUserStore(appDbContext);
            var userManager = new ApplicationUserManager(userStore);
            var user = userManager.Find(A.UserName, A.Password);

            if(user!= null)
            {
                //login
                var authenticationManager = HttpContext.GetOwinContext().Authentication;
                var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                authenticationManager.SignIn(new AuthenticationProperties(), userIdentity);
                return RedirectToAction("Index", "Home");

            }
            else
            {
                ModelState.AddModelError("My Error", "Invalid Data");
                return View();
            }
        }

    }
    
}