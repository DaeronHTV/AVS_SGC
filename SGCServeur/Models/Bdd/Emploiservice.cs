using System;
using System.Collections.Generic;

#nullable disable

namespace SGCServeur.Models.Bdd
{
    public partial class Emploiservice
    {
        public Guid Id { get; set; }
        public Guid Emploiid { get; set; }
        public Guid Serviceid { get; set; }
        public DateTime Datedebut { get; set; }
        public DateTime? Datefin { get; set; }

        public virtual Emploi Emploi { get; set; }
        public virtual Service Service { get; set; }
    }
}
