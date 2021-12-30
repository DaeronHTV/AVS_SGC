using Core.Api.Database.DAO;
using SGCServeur.Models.Bdd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGCServeur.LibrairieBdd
{
    public class EmployeDAO : CommonDAO<Employe>
    {
        private SGCContext _context;

        public EmployeDAO(SGCContext context) : base(context)
        {
            this._context = context;
        }

        public override async Task<bool> Create(Employe objet)
        {
            await base.Create(objet);
            SetAscii(ref objet);
            await context.SaveChangesAsync();
            return true;
        }

        public override async Task<bool> Update(Employe objet, Guid id)
        {
            Employe objetData;
            if (!(await Contains(id)))
            {
                objetData = new Employe();
            }
            else
            {
                objetData = await Read(id);
            }
            objetData.Nom = objet.Nom;
            objetData.Prenom = objet.Prenom;
            objetData.Mail = objet.Mail;
            SetAscii(ref objetData);
            //TODO Faire la gestion des emplois, competences et connaissances
            objetData.Datemaj = DateTime.UtcNow;
            _context.Employes.Update(objetData);
            await context.SaveChangesAsync();
            return true;
        }




        public override IList<Employe> ReadAll(int nbPerPage = 10)
        {
            return _context.Employes.ToList();
        }

        private void SetAscii(ref Employe objet)
        {
            objet.Nomascii = objet.Nom.ToUpper();
            objet.Prenomascii = objet.Prenom.ToUpper();
        }
    }
}
