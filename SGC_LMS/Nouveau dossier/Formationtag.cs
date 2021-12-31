using System;

#nullable disable

namespace SGCServeur.Models.Bdd
{
    public partial class Formationtag
    {
        public Guid Id { get; set; }
        public Guid Tagid { get; set; }
        public Guid Formationid { get; set; }
        public DateTime Datedebut { get; set; }
        public DateTime? Datefin { get; set; }

        public virtual Formation Formation { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
