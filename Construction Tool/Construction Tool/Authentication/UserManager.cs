using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Construction_Tool.Models;

namespace Construction_Tool.Authentication
{
    public class UserManager : UserManager<User>
    {
        public UserManager(IUserStore<User> store)
        : base(store)
        {
        }
        public static UserManager Create(
        IdentityFactoryOptions<UserManager> options, IOwinContext context)
        {
            var manager = new UserManager(
                new UserStore<User>(context.Get<DBModels>()));
            return manager;
        }
    }
}