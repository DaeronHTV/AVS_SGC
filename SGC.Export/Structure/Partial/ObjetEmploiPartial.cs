using SGC.Export.Common;
using SGC.Export.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGC.Export.Structure
{
    public partial class ObjetEmploi : IObjetEmploi
    {
        public int Indice 
        { 
            get => indice; 
            set => indice = value; 
        }

        public IServiceBase Service 
        { 
            get => service; 
            set => service = new ServiceBase
            {
                code = value.Code,
                libelle = value.Libelle
            }; 
        }

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

        IEnumerable<IConComBase> IObjetEmploi.Connaissances 
        { 
            get => Connaissances; 
            set => Connaissances = value.ToArray() as ConComBase[];
        }

        IEnumerable<IConComBase> IObjetEmploi.Competences 
        {
            get => Competences;
            set => Competences = value.ToArray() as ConComBase[];
        }
    }
}
