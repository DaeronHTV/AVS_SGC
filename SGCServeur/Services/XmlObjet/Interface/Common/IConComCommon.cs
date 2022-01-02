using System;

namespace SGCServeur.Services.XmlObjet.Interface.Common
{
    public interface IConComCommon: IConComBase
    {
        int Niveau { get; set; }

        DateTime DateAcquisition { get; set; }
    }
}
