using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Api
{
    public interface IBaseObject
    {
        byte[] Id { get; set; }

        string Code { get; set; }

        DateTime Dateinsertion { get; set; }

        DateTime? Datemaj { get; set; }
    }
}
