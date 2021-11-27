using System;
using System.Collections.Generic;

#nullable disable

namespace SGCServeur.Models
{
    public partial class Employeconnaissance
    {
        public byte[] Id { get; set; }
        public byte[] Connaissanceid { get; set; }
        public byte[] Employeid { get; set; }
        public byte[] Niveau { get; set; }
        public byte[] Dateacquisition { get; set; }

        public virtual Connaissance Connaissance { get; set; }
        public virtual Employe Employe { get; set; }
    }
}
