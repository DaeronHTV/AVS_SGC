using System;
using System.Collections.Generic;

#nullable disable

namespace SGCServeur.Models.Bdd
{
    public partial class Competence
    {
        public Competence()
        {
            Emploicompetences = new HashSet<Emploicompetence>();
            Employecompetences = new HashSet<Employecompetence>();
        }

        public byte[] Id { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public DateTime Dateinsertion { get; set; }
        public DateTime Datemaj { get; set; }

        public virtual ICollection<Emploicompetence> Emploicompetences { get; set; }
        public virtual ICollection<Employecompetence> Employecompetences { get; set; }
    }
}
