using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;

using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity.EntityFramework;
using WebApplication13.Identity;

[assembly: OwinStartup(typeof(WebApplication13.Startup))]

namespace WebApplication13
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            app.UseCookieAuthentication(new CookieAuthenticationOptions() {AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,LoginPath = new PathString("/Account/Login") });
            this.CreateRolesAndUsers();
        }
        public void CreateRolesAndUsers()
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>());
            var appDbContext = new ApplicationDbContext();
            var appUserContext = new ApplicationUserStore(appDbContext);
            var UserManager = new ApplicationUserManager(appUserContext);



        }
    }
}
