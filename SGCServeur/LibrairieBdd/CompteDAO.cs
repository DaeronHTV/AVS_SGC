using SGCServeur.Models.Bdd;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Api.Database.DAO;
using System;

namespace SGCServeur.LibrairieBdd
{
    public class CompteDAO : IDAO<Compte>
    {
        public CompteDAO(SGCContext context)
        {

        }

        public Task<bool> Contains(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Create(Compte objet)
        {
            throw new System.NotImplementedException();
        }

        public Task<Compte> Delete(Guid id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Compte> Read(Guid id)
        {
            throw new System.NotImplementedException();
        }

        public IList<Compte> ReadAll(int nbPerPage = 10)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Compte objet, Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
