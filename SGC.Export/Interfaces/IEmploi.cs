using System.Collections.Generic;

namespace SGC.Export.Interfaces
{
    public interface IEmplois: IXmlBase
    {
        IEnumerable<IObjetEmploi> Employes { get; set; }
    }
}
