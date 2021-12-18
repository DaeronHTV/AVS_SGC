using Core.Api.DAO;
using SGCServeur.Models.Bdd;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SGCServeur.LibrairieBdd
{
    public class EmployeDAO : IDAO<Employe>
    {
        private BaseTestContext context;

        public EmployeDAO(BaseTestContext context)
        {
            this.context = context;
        }

        public async Task<bool> Create(Employe objet)
        {
            var verif = context.Employes.Where(e => e.Code == objet.Code).FirstOrDefault();
            if (verif != null)
            {
                return false;
            }
            objet.Id = Guid.NewGuid().ToByteArray();
            objet.Nomascii = objet.Nom.ToUpper();
            objet.Prenomascii = objet.Prenom.ToUpper();
            await context.Employes.AddAsync(objet);
            await context.SaveChangesAsync();
            return true;
        }

        public Employe Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Employe Read(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Employe objet, string id)
        {
            var objetData = context.Employes.Where(e => e.Id.ToString() == id).FirstOrDefault();
            if(objetData == null)
            {
                //TODO
            }
            objetData.Nom = objet.Nom;
            objetData.Prenom = objet.Prenom;
            objetData.Mail = objet.Mail;
            if(objet.Employecompetences != null && !objet.Employecompetences.Equals(objetData.Employecompetences))
            {
                objetData.Employecompetences = objet.Employecompetences;
            }
            objetData.Datemaj = DateTime.UtcNow;
        }
    }
}
