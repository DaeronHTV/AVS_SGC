using System;
using System.Collections.Generic;

#nullable disable

namespace SGCServeur.Models.Bdd
{
    public partial class Connaissance
    {
        public Connaissance()
        {
            Emploiconnaissances = new HashSet<Emploiconnaissance>();
            Employeconnaissances = new HashSet<Employeconnaissance>();
        }

        public byte[] Id { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public DateTime Dateinsertion { get; set; }
        public DateTime Datemaj { get; set; }

        public virtual ICollection<Emploiconnaissance> Emploiconnaissances { get; set; }
        public virtual ICollection<Employeconnaissance> Employeconnaissances { get; set; }
    }
}
