using SGC.Export.Interfaces;
using System;

namespace SGC.Export.Common
{
    public partial class ConComBase : IConComBase
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

        public string Description 
        { 
            get => description; 
            set => description = value; 
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

        public int Indice 
        { 
            get => indice; 
            set => indice = value; 
        }
    }
}
