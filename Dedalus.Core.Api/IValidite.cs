using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Api
{
    public interface IValidite
    {
        DateTime Datedebutvalidite { get; set; }

        DateTime? Datefinvalidite { get; set; }
    }
}
