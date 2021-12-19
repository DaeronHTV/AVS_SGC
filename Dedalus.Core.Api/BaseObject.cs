using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Api
{
    public class BaseObject: IBaseObject
    {
        public BaseObject(Guid id)
        {
           
        }

        public Guid Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Code { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime Dateinsertion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? Datemaj { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
