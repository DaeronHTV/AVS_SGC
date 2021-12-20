using System;

namespace Core.Api
{
    public interface IValidite
    {
        DateTime Datedebutvalidite { get; set; }

        DateTime? Datefinvalidite { get; set; }
    }
}
