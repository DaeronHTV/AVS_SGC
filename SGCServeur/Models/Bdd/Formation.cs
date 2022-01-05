using System;
using System.Collections.Generic;
using Core.Api;

#nullable disable

namespace SGCServeur.Models.Bdd
{
    public partial class Formation: IBaseObject
    {
        public Formation()
        {
            Formationtags = new HashSet<Formationtag>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
        public string Niveau { get; set; }
        public DateTime Dateinsertion { get; set; }
        public DateTime Datemaj { get; set; }
        public DateTime Datedebutvalidite { get; set; }
        public DateTime? Datefinvalidite { get; set; }

        public virtual ICollection<Formationtag> Formationtags { get; set; }
    }
}
