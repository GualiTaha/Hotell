using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace HotelGestion.Models
{
    public class Role
    {
        public int Id { get; set; }
        [Required]
        public String NomRole { get; set; }
        public virtual List<User> Users { get; set; }
    }
}