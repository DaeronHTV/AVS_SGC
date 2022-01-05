using SGC.Export.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGC.Export.Structure
{
    public partial class Services : IService
    {
        public string Version
        {
            get => version;
            set => version = value;
        }

        public DateTime DateExport
        {
            get => dateExport;
            set => dateExport = value;
        }

        IEnumerable<IServiceBase> IService.Services
        {
            get => Service;
            set => Service = value.ToArray() as ServicesService[];
        }
    }

    public partial class ServicesService : IServiceBase, IIndice
    {
        public int Indice
        {
            get => indice;
            set => indice = value;
        }
    }
}
