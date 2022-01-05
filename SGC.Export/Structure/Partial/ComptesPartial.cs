using SGC.Export.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGC.Export.Structure
{
    public partial class Comptes : IComptes
    {
        public string Version 
        { 
            get => version; 
            set => version = value; 
        }

        public DateTime DateExport 
        { 
            get => dateExport; 
            set => dateExport = value; 
        }

        public IEnumerable<ICompte> ListComptes
        {
            get => Compte;
            set => Compte = value.ToArray() as ComptesCompte[]; 
        }
    }

    public partial class ComptesCompte : ICompte, IIndice
    {
        public string Code 
        { 
            get => code; 
            set => code = value; 
        }

        public string Mail 
        { 
            get => mail; 
            set => mail = value; 
        }

        public int Indice 
        { 
            get => indice; 
            set => indice = value; 
        }

        public string TypeCompte //TODO Transformer en enum
        { 
            get => typeCompte; 
            set => typeCompte = value; 
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
