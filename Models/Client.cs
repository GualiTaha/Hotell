using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace HotelGestion.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Tel { get; set; }
        public string email { get; set; }
        [DataType(DataType.Password)]
        public string Passwd { get; set; }
        public virtual List<Reservation> Reservations { get; set; }
    }
}