using System;
using System.Collections.Generic;
using Core.Api;

#nullable disable

namespace SGCServeur.Models.Bdd
{
    public partial class Emploi: IBaseObject
    {
        public Emploi()
        {
            Emploicompetences = new HashSet<Emploicompetence>();
            Emploiconnaissances = new HashSet<Emploiconnaissance>();
            Emploiservices = new HashSet<Emploiservice>();
            Employeemplois = new HashSet<Employeemploi>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public DateTime Dateinsertion { get; set; }
        public DateTime Datemaj { get; set; }
        public DateTime Datedebutvaldite { get; set; }
        public DateTime? Datefinvaldite { get; set; }

        public virtual ICollection<Emploicompetence> Emploicompetences { get; set; }
        public virtual ICollection<Emploiconnaissance> Emploiconnaissances { get; set; }
        public virtual ICollection<Emploiservice> Emploiservices { get; set; }
        public virtual ICollection<Employeemploi> Employeemplois { get; set; }
    }
}
