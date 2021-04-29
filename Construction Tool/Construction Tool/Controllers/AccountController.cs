using Construction_Tool.Models;
using Construction_Tool.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace Construction_Tool.Controllers
{
    public class AccountController : Controller
    {
        DBModels dbModel = new DBModels();
        // GET: Account
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            try
            {
                if (Request.IsAuthenticated)
                {
                    return RedirectToLocal(returnUrl);
                }
            }
            catch (Exception e)
            {

            }
            return View();
        }
        // POST: Account
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(OwnerViewModel ovm, string returnUrl)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    List<owner> loginInfo = dbModel.owners.Where(x => x.USER.ToUpper() == ovm.Owner.USER.ToUpper() && x.PASSWORD == ovm.Owner.PASSWORD).ToList();
                    if(loginInfo != null && loginInfo.Count() > 0)
                    {
                        owner logindetails = loginInfo.First();
                        SignInUser(logindetails, false);
                        return RedirectToLocal(returnUrl);
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid username or password.");
                }
            }
            catch(Exception e)
            {

            }
            return View(ovm);
        }
        private void SignInUser(owner owner, bool isPersistent)
        {
            var claims = new List<Claim>();

            try
            {
                claims.Add(new Claim(ClaimTypes.Name, owner.USER));
                claims.Add(new Claim(ClaimTypes.NameIdentifier, owner.OWNER_ID.ToString()));
                var claimIdentities = new ClaimsIdentity(claims, DefaultAuthenticationTypes.ApplicationCookie);
                var ctx = Request.GetOwinContext();
                var authenticationManager = ctx.Authentication;
                authenticationManager.SignIn(new Microsoft.Owin.Security.AuthenticationProperties() { IsPersistent = isPersistent }, claimIdentities);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        private void ClaimIdentities(string username, bool isPersistent)
        {
            var claims = new List<Claim>();

            try
            {
                claims.Add(new Claim(ClaimTypes.Name, username));
                var claimIdentities = new ClaimsIdentity(claims, DefaultAuthenticationTypes.ApplicationCookie);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public ActionResult Logout()
        {
            var ctx = Request.GetOwinContext();
            var authenticationManager = ctx.Authentication;
            authenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return RedirectToAction("Login", "Account");
        }
        private ActionResult RedirectToLocal(string returnUrl)
        {
            try
            {
                if(Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            return RedirectToAction("Index", "Home");
        }
    }
    
}