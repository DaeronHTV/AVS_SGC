using System;
using System.Collections.Generic;

#nullable disable

namespace SGCServeur.Models
{
    public partial class Employeemploi
    {
        public byte[] Id { get; set; }
        public byte[] Employeid { get; set; }
        public byte[] Emploiid { get; set; }
        public byte[] Datedebut { get; set; }
        public byte[] Datefin { get; set; }

        public virtual Emploi Emploi { get; set; }
        public virtual Employe Employe { get; set; }
    }
}
