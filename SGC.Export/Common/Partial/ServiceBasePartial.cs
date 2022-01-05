using SGC.Export.Interfaces;
using System;

namespace SGC.Export.Common
{
    public partial class ServiceBase : IServiceBase
    {
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
    }
}
