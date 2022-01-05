using SGC.Export.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGC.Export.Structure
{
    public partial class Emplois : IEmplois
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

        public IEnumerable<IObjetEmploi> Employes 
        { 
            get => Emploi; 
            set => Emploi = value.ToArray() as ObjetEmploi[]; 
        }
    }
}
