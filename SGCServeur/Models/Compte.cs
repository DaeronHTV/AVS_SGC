using System;
using System.Collections.Generic;

#nullable disable

namespace SGCServeur.Models
{
    public partial class Compte
    {
        public byte[] Id { get; set; }
        public byte[] Employeid { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string Typecompte { get; set; }
        public byte[] Dateinsertion { get; set; }
        public byte[] Datemaj { get; set; }

        public virtual Employe Employe { get; set; }
    }
}
