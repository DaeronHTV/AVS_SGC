using Core.Api.DAO;
using SGCServeur.Models.Bdd;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Api.DAO;

namespace SGCServeur.LibrairieBdd
{
    public class CompteDAO : IDAO<Compte>
    {
        public CompteDAO(SGCContext context)
        {

        }

        public bool Contains(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Create(Compte objet)
        {
            throw new System.NotImplementedException();
        }

        public Task<Compte> Delete(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Compte> Read(string id)
        {
            throw new System.NotImplementedException();
        }

        public IList<Compte> ReadAll(int nbPerPage = 10)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(Compte objet, string id)
        {
            throw new System.NotImplementedException();
        }
    }
}
