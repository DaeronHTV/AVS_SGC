using System;

#nullable disable

namespace SGCServeur.Models.Bdd
{
    public partial class Employecompetence
    {
        public Guid Id { get; set; }
        public Guid Competenceid { get; set; }
        public Guid Employeid { get; set; }
        public string Niveau { get; set; }
        public DateTime Dateacquisition { get; set; }

        public virtual Competence Competence { get; set; }
        public virtual Employe Employe { get; set; }
    }
}
