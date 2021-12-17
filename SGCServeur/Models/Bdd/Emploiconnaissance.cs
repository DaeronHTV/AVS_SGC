using System;

#nullable disable

namespace SGCServeur.Models.Bdd
{
    public partial class Emploiconnaissance
    {
        public byte[] Id { get; set; }
        public byte[] Connaissanceid { get; set; }
        public byte[] Emploiid { get; set; }
        public DateTime Datedebut { get; set; }
        public DateTime Datefin { get; set; }

        public virtual Connaissance Connaissance { get; set; }
        public virtual Emploi Emploi { get; set; }
    }
}
