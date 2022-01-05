using System.Collections.Generic;

namespace SGC.Export.Interfaces
{
    public interface IObjetEmploi: IObjetBase
    {
        public int Indice { get; set; }

        public IEnumerable<IConComBase> Connaissances { get; set; }

        public IEnumerable<IConComBase> Competences { get; set; }

        public IServiceBase Service { get; set; }
    }
}