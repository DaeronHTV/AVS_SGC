using System;
using System.Collections.Generic;
using Core.Api;

#nullable disable

namespace SGCServeur.Models.Bdd
{
    public partial class Contenue: IBaseObject
    {
        public Guid Id { get; set; }
        public DateTime Dateinsertion { get; set; }
        public DateTime Datemaj { get; set; }
        public DateTime Datedebutvalidite { get; set; }
        public DateTime? Datefinvalidite { get; set; }
        public string Code { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
