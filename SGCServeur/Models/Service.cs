using System;
using System.Collections.Generic;

#nullable disable

namespace SGCServeur.Models
{
    public partial class Service
    {
        public Service()
        {
            Emploiservices = new HashSet<Emploiservice>();
        }

        public byte[] Id { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public byte[] Dateinsertion { get; set; }
        public byte[] Datemaj { get; set; }

        public virtual ICollection<Emploiservice> Emploiservices { get; set; }
    }
}
