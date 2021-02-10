using SchemaMockUp.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace SchemaMockUp.Services
{   
    class CRUD
    {
        public static void CreateItem()
        {
            using (var db = new EFContext())
            {
                //var user = new User();
                //user.Email = "kallelöf@hotmail.com";
                //user.City  =  "Stockholm";
                //user.PostalCode = "123";

                //var user2 = new User();
                //user2.Email = "håkaneriksson@gmail.com";
                //user2.City = "Bro";
                //user2.PostalCode = "197";

                //var role = new Role();
                //role.NameOfRole = "Student";
                //role.NormalizedName = "Student";
                //db.Add(role);
                //db.Add(user);
                //db.Add(user2);

                //var userRole = new UserRole();
                //userRole.RoleId = 1;
                //userRole.UserId = 3;


                //var userRole3 = new UserRole();
                //userRole3.RoleId = 2;
                //userRole3.UserId = 1;

                var userRole2 = new UserRole();
                userRole2.RoleID = 2;
                userRole2.UserID = 2;

                //db.Add(userRole);
                db.Add(userRole2);
                //db.Add(userRole3);
                db.SaveChanges();              
            }
        }
    }
}
