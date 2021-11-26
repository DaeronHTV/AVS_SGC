using System;
using System.Collections.Generic;

#nullable disable

namespace SGCServeur.Models
{
    public partial class Employecompetence
    {
        public byte[] Id { get; set; }
        public byte[] Competenceid { get; set; }
        public byte[] Employeid { get; set; }
        public byte[] Niveau { get; set; }
        public byte[] Dateacquisition { get; set; }

        public virtual Competence Competence { get; set; }
        public virtual Employe Employe { get; set; }
    }
}
