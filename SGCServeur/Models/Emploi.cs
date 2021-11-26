using System;
using System.Collections.Generic;

#nullable disable

namespace SGCServeur.Models
{
    public partial class Emploi
    {
        public Emploi()
        {
            Emploicompetences = new HashSet<Emploicompetence>();
            Emploiconnaissances = new HashSet<Emploiconnaissance>();
            Emploiservices = new HashSet<Emploiservice>();
            Employeemplois = new HashSet<Employeemploi>();
        }

        public byte[] Id { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public byte[] Dateinsertion { get; set; }
        public byte[] Datemaj { get; set; }

        public virtual ICollection<Emploicompetence> Emploicompetences { get; set; }
        public virtual ICollection<Emploiconnaissance> Emploiconnaissances { get; set; }
        public virtual ICollection<Emploiservice> Emploiservices { get; set; }
        public virtual ICollection<Employeemploi> Employeemplois { get; set; }
    }
}
