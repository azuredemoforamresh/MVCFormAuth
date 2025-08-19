using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace MVC.Models
{
    public class UserModel
    {
        public int ID { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserPassword { get; set; }
        public string[] Role { get; set; }
        public static List< UserModel> GetUser()
        {
            
            List<UserModel> lst = new List<UserModel>()
            {
                new UserModel() {ID=100,UserName="amresh",UserPassword="admin",Role=new string[]{"admin"} },
                 new UserModel() {ID=100,UserName="chandra",UserPassword="hr",Role=new string[]{"hr"} }
            };
            return lst;
        }
    }
}