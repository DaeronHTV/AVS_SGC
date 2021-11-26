using System;
using System.Collections.Generic;

#nullable disable

namespace SGCServeur.Models
{
    public partial class Connaissance
    {
        public Connaissance()
        {
            Emploiconnaissances = new HashSet<Emploiconnaissance>();
        }

        public byte[] Id { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public byte[] Dateinsertion { get; set; }
        public byte[] Datemaj { get; set; }

        public virtual ICollection<Emploiconnaissance> Emploiconnaissances { get; set; }
    }
}
