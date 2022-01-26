using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
namespace WebApplication13.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime? Birthday { get; set; }
        public DateTime? Address { get; set; }
        public DateTime? City { get; set; }
    }
}