using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelGestion.Models
{
    public class Facture
    {
        public int Id { get; set; }
        public double Prix { get; set; }
    }
}