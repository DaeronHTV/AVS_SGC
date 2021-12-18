using Core.Api;
using System;

#nullable disable

namespace SGCServeur.Models.Bdd
{
    public partial class Compte
    {
        public byte[] Id { get; set; }
        public byte[] Employeid { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string Typecompte { get; set; }
        public DateTime Dateinsertion { get; set; }
        public DateTime Datemaj { get; set; }

        public virtual Employe Employe { get; set; }
    }
}
