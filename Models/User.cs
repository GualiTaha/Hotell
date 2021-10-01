using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace HotelGestion.Models
{
    public class User
    {
        public User()
        {
        }
        public User(string login, string pwd, Role role)
        {
            Login = login;
            Pwd = pwd;
            role = new Role();

        }

        public int Id { get; set; }


        [Required, Display(Name = "Email")]
        public string Login { get; set; }

        [Display(Name = "Password"), DataType(DataType.Password)]
        public string Pwd { get; set; }
        public virtual Role UserRole { get; set; }
    }
}