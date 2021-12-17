using System;

#nullable disable

namespace SGCServeur.Models.Bdd
{
    public partial class Emploicompetence
    {
        public byte[] Id { get; set; }
        public byte[] Competenceid { get; set; }
        public byte[] Emploiid { get; set; }
        public DateTime Datedebut { get; set; }
        public DateTime Datefin { get; set; }

        public virtual Competence Competence { get; set; }
        public virtual Emploi Emploi { get; set; }
    }
}
