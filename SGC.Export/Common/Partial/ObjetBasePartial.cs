using SGC.Export.Interfaces;
using System;

namespace SGC.Export.Common
{
    public partial class ObjetBase : IObjetBase
    {
        public string Code
        {
            get => code;
            set => code = value;
        }

        public string Libelle
        {
            get => libelle;
            set => libelle = value;
        }

        public DateTime DateInsertion
        {
            get => dateInsertion;
            set => dateInsertion = value;
        }

        public DateTime DateMaj
        {
            get => dateMaj;
            set => dateMaj = value;
        }
    }
}
