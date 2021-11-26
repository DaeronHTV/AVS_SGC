using System;
using System.Collections.Generic;

#nullable disable

namespace SGCServeur.Models
{
    public partial class Employe
    {
        public Employe()
        {
            Employecompetences = new HashSet<Employecompetence>();
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
        public byte[] Dateinsertion { get; set; }
        public byte[] Datemaj { get; set; }

        public virtual ICollection<Employecompetence> Employecompetences { get; set; }
        public virtual ICollection<Employeemploi> Employeemplois { get; set; }
    }
}
