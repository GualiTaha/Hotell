using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelGestion.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public virtual Chambre Chambre { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int NbrJour { get; set; }
        public int Price { get; set; }
        public Client client { get; set; }
    }
}