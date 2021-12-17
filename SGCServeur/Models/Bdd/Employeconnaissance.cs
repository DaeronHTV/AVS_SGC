using System;

#nullable disable

namespace SGCServeur.Models.Bdd
{
    public partial class Employeconnaissance
    {
        public byte[] Id { get; set; }
        public byte[] Connaissanceid { get; set; }
        public byte[] Employeid { get; set; }
        public byte[] Niveau { get; set; }
        public DateTime Dateacquisition { get; set; }

        public virtual Connaissance Connaissance { get; set; }
        public virtual Employe Employe { get; set; }
    }
}
