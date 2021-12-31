using System;
using System.Collections.Generic;
using Core.Api;

#nullable disable

namespace SGCServeur.Models.Bdd
{
    public partial class Service: IBaseObject
    {
        public Service()
        {
            Emploiservices = new HashSet<Emploiservice>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public DateTime Dateinsertion { get; set; }
        public DateTime? Datemaj { get; set; }
        public DateTime Datedebutvaldite { get; set; }
        public DateTime? Datefinvaldite { get; set; }

        public virtual ICollection<Emploiservice> Emploiservices { get; set; }
    }
}
