using System;
using System.Collections.Generic;
using Core.Api;

#nullable disable

namespace SGCServeur.Models.Bdd
{
    public partial class Competence: IBaseObject
    {
        public Competence()
        {
            Emploicompetences = new HashSet<Emploicompetence>();
            Employecompetences = new HashSet<Employecompetence>();
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
        public virtual ICollection<Employecompetence> Employecompetences { get; set; }
    }
}
