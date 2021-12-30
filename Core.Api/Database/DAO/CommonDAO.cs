using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Core.Api.Database.DAO
{
    public abstract class CommonDAO<T> : IDAO<T> where T : IBaseObject
    {
        protected readonly DbContext context;

        public CommonDAO(DbContext context)
        {
            this.context = context;
        }

        public virtual async Task<bool> Create(T objet)
        {
            objet.Id = Guid.NewGuid();
            objet.Dateinsertion = DateTime.UtcNow;
            await context.AddAsync(objet);
            return true;
        }

        public virtual async Task<T> Read(Guid id)
        {
            return (T)await context.FindAsync(typeof(T), id);
        }

        public virtual async Task<T> Delete(Guid id)
        {
            var objet = (T)await context.FindAsync(typeof(T), id);
            context.Remove(objet);
            await context.SaveChangesAsync();
            return objet;
        }

        public async virtual Task<bool> Contains(Guid id)
        {
            return (await context.FindAsync(typeof(T), id)) != null;
        }

        public abstract Task<bool> Update(T objet, Guid id);

        public abstract IList<T> ReadAll(int nbPerPage = 10);
    }
}
