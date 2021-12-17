using System;

#nullable disable

namespace SGCServeur.Models.Bdd
{
    public partial class Employeemploi
    {
        public byte[] Id { get; set; }
        public byte[] Employeid { get; set; }
        public byte[] Emploiid { get; set; }
        public DateTime Datedebut { get; set; }
        public DateTime Datefin { get; set; }

        public virtual Emploi Emploi { get; set; }
        public virtual Employe Employe { get; set; }
    }
}
