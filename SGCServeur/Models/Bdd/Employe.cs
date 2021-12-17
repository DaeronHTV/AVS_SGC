using System;
using System.Collections.Generic;

#nullable disable

namespace SGCServeur.Models.Bdd
{
    public partial class Employe
    {
        public Employe()
        {
            Employecompetences = new HashSet<Employecompetence>();
            Employeconnaissances = new HashSet<Employeconnaissance>();
            Employeemplois = new HashSet<Employeemploi>();
        }

        public byte[] Id { get; set; }
        public string Code { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Prenomascii { get; set; }
        public string Nomascii { get; set; }
        public byte[] Photo { get; set; }
        public byte[] Telephone { get; set; }
        public string Mail { get; set; }
        public DateTime Dateinsertion { get; set; }
        public DateTime Datemaj { get; set; }

        public virtual Compte Compte { get; set; }
        public virtual ICollection<Employecompetence> Employecompetences { get; set; }
        public virtual ICollection<Employeconnaissance> Employeconnaissances { get; set; }
        public virtual ICollection<Employeemploi> Employeemplois { get; set; }
    }
}
