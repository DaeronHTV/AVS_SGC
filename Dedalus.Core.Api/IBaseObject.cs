using System;

namespace Core.Api
{
    public interface IBaseObject
    {
        Guid Id { get; set; }

        string Code { get; set; }

        DateTime Dateinsertion { get; set; }

        DateTime? Datemaj { get; set; }
    }
}
