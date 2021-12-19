using System;

#nullable disable

namespace SGCServeur.Models.Bdd
{
    public partial class Employeconnaissance
    {
        public Guid Id { get; set; }
        public Guid Connaissanceid { get; set; }
        public Guid Employeid { get; set; }
        public string Niveau { get; set; }
        public DateTime Dateacquisition { get; set; }

        public virtual Connaissance Connaissance { get; set; }
        public virtual Employe Employe { get; set; }
    }
}
