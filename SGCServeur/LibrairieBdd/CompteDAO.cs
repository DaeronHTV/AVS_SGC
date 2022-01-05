using SGCServeur.Models.Bdd;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Api.DAO;
using System;
using System.Linq;

namespace SGCServeur.LibrairieBdd
{
    public class CompteDAO : CommonDAO<Compte>
    {
        private SGCContext _context;

        public CompteDAO(SGCContext context): base(context)
        {
            this._context = context;
        }

        public override async Task<bool> Create(Compte objet)
        {
            await base.Create(objet);
            var test = await _context.Employes.FindAsync(new object[]{Guid.Parse("74ad4f0c-5f5a-4e19-9c2c-7d7b1c5b2311")});
            await context.SaveChangesAsync();
            return true;
        }

        public override async Task<bool> Update(Compte objet, Guid id)
        {
            Compte objetData;
            if (!(await Contains(id)))
            {
                objetData = new Compte();
            }
            else
            {
                objetData = await Read(id);
            }
            objetData.Mail = objet.Mail;
            //TODO Faire la gestion des emplois, competences et connaissances
            objetData.Datemaj = DateTime.UtcNow;
            _context.Comptes.Update(objetData);
            await context.SaveChangesAsync();
            return true;
        }

        public override IList<Compte> ReadAll(int nbPerPage = 10)
        {
            return _context.Comptes.ToList();
        }
    }
}
