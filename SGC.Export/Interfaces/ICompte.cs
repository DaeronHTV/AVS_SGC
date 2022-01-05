using System;
using System.Collections.Generic;

namespace SGC.Export.Interfaces
{
    public interface IComptes: IXmlBase
    {
        IEnumerable<ICompte> Comptes { get; set; }
    }

    public interface ICompte
    {
        string Code { get; set; }

        string Mail { get; set; }

        int Indice { get; set; }

        TypeCompteEnum TypeCompte { get; set; }

        DateTime DateInsertion { get; set; }

        DateTime DateMaj { get; set; }
    }
}
