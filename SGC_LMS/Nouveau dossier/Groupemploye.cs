using System;

#nullable disable

namespace SGCServeur.Models.Bdd
{
    public partial class Groupemploye
    {
        public Guid Id { get; set; }
        public Guid Employeid { get; set; }
        public Guid Groupid { get; set; }
        public DateTime Datedebut { get; set; }
        public DateTime? Datefin { get; set; }

        public virtual Employe Employe { get; set; }
        public virtual Group Group { get; set; }
    }
}
