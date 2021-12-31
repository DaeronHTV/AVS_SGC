using System;
using System.Collections.Generic;

#nullable disable

namespace SGCServeur.Models.Bdd
{
    public partial class Emploicompetence
    {
        public Guid Id { get; set; }
        public Guid Competenceid { get; set; }
        public Guid Emploiid { get; set; }
        public DateTime Datedebut { get; set; }
        public DateTime? Datefin { get; set; }

        public virtual Competence Competence { get; set; }
        public virtual Emploi Emploi { get; set; }
    }
}
