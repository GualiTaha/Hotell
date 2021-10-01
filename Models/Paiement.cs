using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelGestion.Models
{
    public class Paiement
    {

        public int id { get; set; }
        public string numeroCarte { get; set; }
        public DateTime dateValidite { get; set; }

        public int ccv { get; set; }
    }
}