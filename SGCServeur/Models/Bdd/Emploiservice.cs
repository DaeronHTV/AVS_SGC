using System;

#nullable disable

namespace SGCServeur.Models.Bdd
{
    public partial class Emploiservice
    {
        public byte[] Id { get; set; }
        public byte[] Emploiid { get; set; }
        public byte[] Serviceid { get; set; }
        public DateTime Datedebut { get; set; }
        public DateTime Datefin { get; set; }

        public virtual Emploi Emploi { get; set; }
        public virtual Service Service { get; set; }
    }
}
