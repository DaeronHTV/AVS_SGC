using System;

namespace Core.Api
{
    public interface IRelation
    {
        byte[] IdTable1 { get; set; }

        byte[] IdTable2 { get; set; }

        DateTime Datedebut { get; set; }

        DateTime? Datefin { get; set; }
    }
}
