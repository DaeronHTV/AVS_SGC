using System;
using System.Collections.Generic;
using Core.Api;

#nullable disable

namespace SGCServeur.Models.Bdd
{
    public partial class Tag: IBaseObject
    {
        public Tag()
        {
            Formationtags = new HashSet<Formationtag>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public DateTime Dateinsertion { get; set; }
        public DateTime? Datemaj { get; set; }
        public DateTime Datedebutvalidite { get; set; }
        public DateTime? Datefinvalidite { get; set; }

        public virtual ICollection<Formationtag> Formationtags { get; set; }
    }
}
