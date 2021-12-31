using System;
using System.Collections.Generic;

#nullable disable

namespace SGCServeur.Models.Bdd
{
    public partial class Employeemploi
    {
        public Guid Id { get; set; }
        public Guid Employeid { get; set; }
        public Guid Emploiid { get; set; }
        public DateTime Datedebut { get; set; }
        public DateTime? Datefin { get; set; }

        public virtual Emploi Emploi { get; set; }
        public virtual Employe Employe { get; set; }
    }
}
