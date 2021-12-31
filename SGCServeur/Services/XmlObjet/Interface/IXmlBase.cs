using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGCServeur.Services
{
    public interface IXmlBase
    {
        string Version { get; set; }

        DateTime DateExport { get; set; }
    }
}
