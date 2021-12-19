using System;
using Core.Api;

#nullable disable

namespace SGCServeur.Models.Bdd
{
    public partial class Auteur: IBaseObject
    {
        public Guid Id { get; set; }
        public Guid Compteid { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Prenomascii { get; set; }
        public string Nomascii { get; set; }
        public string Mail { get; set; }
        public DateTime Dateinsertion { get; set; }
        public DateTime? Datemaj { get; set; }
        public DateTime Datedebutvalidite { get; set; }
        public DateTime? Datefinvalidite { get; set; }

        public virtual Compte Compte { get; set; }
        public string Code { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
