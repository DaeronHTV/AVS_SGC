using System;

#nullable disable

namespace SGCServeur.Models.Bdd
{
    public partial class Parametre
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public string Valeur { get; set; }
    }
}
