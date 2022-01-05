using System;
using System.Collections.Generic;
using Core.Api;

#nullable disable

namespace SGCServeur.Models.Bdd
{
    public partial class Compte: IBaseObject
    {
        public Compte()
        {
            Auteurs = new HashSet<Auteur>();
        }

        public Guid Id { get; set; }
        public Guid Employeid { get; set; }
        public string Code { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string Typecompte { get; set; }
        public DateTime Dateinsertion { get; set; }
        public DateTime Datemaj { get; set; }
        public DateTime Datedebutvaldite { get; set; }
        public DateTime? Datefinvaldite { get; set; }

        public virtual Employe Employe { get; set; }
        public virtual ICollection<Auteur> Auteurs { get; set; }
    }
}
