using System;
using System.Collections.Generic;

#nullable disable

namespace SGCServeur.Models
{
    public partial class Emploiconnaissance
    {
        public byte[] Id { get; set; }
        public byte[] Connaissanceid { get; set; }
        public byte[] Emploiid { get; set; }
        public byte[] Datedebut { get; set; }
        public byte[] Datefin { get; set; }

        public virtual Connaissance Connaissance { get; set; }
        public virtual Emploi Emploi { get; set; }
    }
}
