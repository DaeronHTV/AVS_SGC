using System;

namespace SGC.Export.Interfaces
{
    public interface IXmlBase
    {
        string Version { get; set; }

        DateTime DateExport { get; set; }
    }
}
