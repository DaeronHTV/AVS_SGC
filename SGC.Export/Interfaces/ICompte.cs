using System;
using System.Collections.Generic;

namespace SGC.Export.Interfaces
{
    public interface IComptes: IXmlBase
    {
        IEnumerable<ICompte> ListComptes { get; set; }
    }

    public interface ICompte: IBdDate
    {
        string Code { get; set; }

        string Mail { get; set; }

        string TypeCompte { get; set; } //TODO Transformer en enum
    }
}
