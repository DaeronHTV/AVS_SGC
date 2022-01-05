using System.Collections.Generic;
using System;

namespace SGC.Export.Interfaces
{
    public interface IEmployes: IXmlBase
    {
        IEnumerable<IEmploye> Employes { get; set; }
    }

    public interface IEmploye
    {
        string Code { get; set; }

        string Libelle { get; set; }

        string Description { get; set; }

        DateTime DateInsertion { get; set; }

        DateTime DateMaj { get; set; }

        ICompte Compte { get; set; }

        IEnumerable<IEmploi> Emplois { get; set; }

        IEnumerable<ICompetence> Competences { get; set; }

        IEnumerable<IConnaissance> Connaissances { get; set; }
    }
}
