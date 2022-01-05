using System.Collections.Generic;

namespace SGC.Export.Interfaces
{
    public interface IService: IXmlBase
    {
        IEnumerable<IServiceBase> Services { get; set; }
    }
}
