using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelGestion.Models
{
    public class Chambre
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public ChambreType ChambreType { get; set; }
        public string Options { get; set; }
        public bool Etat { get; set; }
        public int Prix { get; set; }
        public byte[] Image { get; set; }

}
}