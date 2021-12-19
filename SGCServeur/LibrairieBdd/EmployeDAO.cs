using Core.Api.DAO;
using SGCServeur.Models.Bdd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGCServeur.LibrairieBdd
{
    public class EmployeDAO : IDAO<Employe>
    {
        private SGCContext context;

        public EmployeDAO(SGCContext context)
        {
            this.context = context;
        }

        public async Task<bool> Create(Employe objet)
        {
            objet.Id = Guid.NewGuid();
            SetAscii(ref objet);
            await context.Employes.AddAsync(objet);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<Employe> Read(string id)
        {
            return await context.Employes.FindAsync(id);
        }

        public IList<Employe> ReadAll(int nbPerPage = 10)
        {
            return context.Employes.ToList();
        }

        public async Task<bool> Update(Employe objet, string id)
        {
            var objetData = context.Employes.Where(e => e.Id.ToString() == id).FirstOrDefault();
            if(objetData == null)
            {
                //TODO
            }
            objetData.Nom = objet.Nom;
            objetData.Prenom = objet.Prenom;
            objetData.Mail = objet.Mail;
            SetAscii(ref objetData);
            //TODO Faire la gestion des emplois, competences et connaissances
            objetData.Datemaj = DateTime.UtcNow;
            context.Employes.Update(objetData);
            await context.SaveChangesAsync();
            return true;
        }

        public bool Contains(string id)
        {
            return context.Employes.Where(e => e.Code == id).FirstOrDefault() != null;
        }

        public async Task<Employe> Delete(string id)
        {
            var objet = await context.Employes.FindAsync(id);
            context.Employes.Remove(objet);
            await context.SaveChangesAsync();
            return objet;
        }

        private void SetAscii(ref Employe objet)
        {
            objet.Nomascii = objet.Nom.ToUpper();
            objet.Prenomascii = objet.Prenom.ToUpper();
        }
    }
}
