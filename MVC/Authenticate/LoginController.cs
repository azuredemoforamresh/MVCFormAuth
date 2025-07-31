using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MVC.Models;
namespace MVC.Authenticate
{
    public class LoginController : Controller
    {
        // GET: Account
        public ActionResult Login(UserModel usrModel=null)
        {
            if (usrModel != null)
            {
                if(UserModel.GetUser().Where(x=>x.UserName==usrModel.UserName && x.UserPassword==usrModel.UserPassword).Any())
                {
                    FormsAuthentication.SetAuthCookie(usrModel.UserName, false);
                    return RedirectToAction("Index", "Home");
                   
                }
                else
                {
                    ModelState.AddModelError("LoginFailed", "invalid Username or Password");
                }
              
            }
            else 
            { 
            }
            return View();
        }
    }
}