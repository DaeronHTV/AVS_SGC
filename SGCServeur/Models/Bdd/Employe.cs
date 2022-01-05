using System;
using System.Collections.Generic;
using Core.Api;

#nullable disable

namespace SGCServeur.Models.Bdd
{
    public partial class Employe: IBaseObject
    {
        public Employe()
        {
            Comptes = new HashSet<Compte>();
            Employecompetences = new HashSet<Employecompetence>();
            Employeconnaissances = new HashSet<Employeconnaissance>();
            Employeemplois = new HashSet<Employeemploi>();
            Groupemployes = new HashSet<Groupemploye>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Prenomascii { get; set; }
        public string Nomascii { get; set; }
        public byte[] Photo { get; set; }
        public string Telephone { get; set; }
        public string Mail { get; set; }
        public DateTime Dateinsertion { get; set; }
        public DateTime Datemaj { get; set; }
        public DateTime Datedebutvaldite { get; set; }
        public DateTime? Datefinvaldite { get; set; }

        public virtual ICollection<Compte> Comptes { get; set; }
        public virtual ICollection<Employecompetence> Employecompetences { get; set; }
        public virtual ICollection<Employeconnaissance> Employeconnaissances { get; set; }
        public virtual ICollection<Employeemploi> Employeemplois { get; set; }
        public virtual ICollection<Groupemploye> Groupemployes { get; set; }
    }
}
