using System;

namespace SGC.Export.Interfaces
{
    public interface IConComBase
	{
		string Code { get; set; }

		string Libelle { get; set; }

		string Description { get; set; }

		DateTime DateInsertion { get; set; }

		DateTime DateMaj { get; set; }

		int Indice { get; set; }
    }
}
