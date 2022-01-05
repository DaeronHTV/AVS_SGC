using SGC.Export.Interfaces;
using System;

namespace SGC.Export.Common
{
    public partial class ConComCommun : IConComCommon
    {
        public int Niveau 
        { 
            get => niveau; 
            set => niveau = value; 
        }

        public DateTime DateAcquisition 
        { 
            get => dateAcquisition; 
            set => dateAcquisition = value; 
        }
    }
}
