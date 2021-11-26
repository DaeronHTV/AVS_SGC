using System;
using System.Collections.Generic;

#nullable disable

namespace SGCServeur.Models
{
    public partial class Emploicompetence
    {
        public byte[] Id { get; set; }
        public byte[] Competenceid { get; set; }
        public byte[] Emploiid { get; set; }
        public byte[] Datedebut { get; set; }
        public byte[] Datefin { get; set; }

        public virtual Competence Competence { get; set; }
        public virtual Emploi Emploi { get; set; }
    }
}
