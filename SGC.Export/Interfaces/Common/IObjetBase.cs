using System;

namespace SGC.Export.Interfaces
{
    public interface IObjetBase: IBdDate
    {
        string Code { get; set; }

        string Libelle { get; set; }
    }
}
