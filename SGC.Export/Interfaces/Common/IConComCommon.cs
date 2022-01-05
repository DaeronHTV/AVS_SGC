using System;

namespace SGC.Export.Interfaces
{
    public interface IConComCommon: IConComBase
    {
        int Niveau { get; set; }

        DateTime DateAcquisition { get; set; }
    }
}
