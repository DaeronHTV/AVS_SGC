using System;

#nullable disable

namespace SGCServeur.Models.Bdd
{
    public partial class Employecompetence
    {
        public byte[] Id { get; set; }
        public byte[] Competenceid { get; set; }
        public byte[] Employeid { get; set; }
        public byte[] Niveau { get; set; }
        public DateTime Dateacquisition { get; set; }

        public virtual Competence Competence { get; set; }
        public virtual Employe Employe { get; set; }
    }
}
