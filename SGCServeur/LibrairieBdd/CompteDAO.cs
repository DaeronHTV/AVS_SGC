using SGCServeur.Models.Bdd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGCServeur.LibrairieBdd
{
    public class CompteDAO
    {
        public CompteDAO(BaseTestContext context)
        {

        }

        public bool Create(Compte compte)
        {
            throw new NotImplementedException("Not Implemented Yet !");
        }

        public bool Update(Compte compte)
        {
            throw new NotImplementedException("Not Implemented Yet !");
        }

        public Compte Read(string id)
        {
            throw new NotImplementedException("Not Implemented Yet !");
        }

        public bool Contains(string id, out Compte result)
        {
            throw new NotImplementedException("Not Implemented Yet !");
        }

        public bool Contains(string code)
        {
            throw new NotImplementedException("Not Implemented Yet !");
        }
    }
}
