using System.Collections.Generic;
using System;

namespace SGC.Export.Interfaces
{
    public interface IEmployes: IXmlBase
    {
        IEnumerable<IEmploye> Employes { get; set; }
    }

    public interface IEmploye: IObjetBase
    {
        string Description { get; set; }

        ICompte Compte { get; set; }

        IEnumerable<IEmploi> Emplois { get; set; }

        IEnumerable<IConComCommon> Competences { get; set; }

        IEnumerable<IConComCommon> Connaissances { get; set; }
    }

    public interface IEmploi: IObjetEmploi
    {
        public DateTime DateDebut { get; set; }

        public DateTime DateFin { get; set; }
    }
}
