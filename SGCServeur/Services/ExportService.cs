using Core.Api.Config;
using SGC.Export.Interfaces;
using SGC.Export.Structure;
using SGCServeur.Models.Bdd;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SGCServeur.Services
{
    public class ExportService
    {
        private SGCContext context;
        private XmlSerializer serialiseur = null;

        public ExportService(SGCContext context)
        {
            this.context = context;
        }


        public async Task<(string, byte[])> GetComptes(string[] values, bool isCode = false)
        {
            IEnumerable<Compte> comptesBdd;
            List<string> Values = values.ToList();
            if (isCode)
                comptesBdd = await context.Comptes.TakeWhile(compte => Values.Contains(compte.Code)).ToListAsync();
            else
                comptesBdd = await context.Comptes.TakeWhile(compte => Values.Contains(compte.Id.ToString())).ToListAsync();
            using (Stream file = new MemoryStream())
            {
                List<ICompte> listCompte = new List<ICompte>();
                foreach (Compte compte in comptesBdd)
                {
                    ICompte mutant = new ComptesCompte
                    {
                        Code = compte.Code,
                        Mail = compte.Mail,
                        TypeCompte = compte.Typecompte,
                        DateInsertion = compte.Dateinsertion,
                        DateMaj = compte.Datemaj
                    };
                    listCompte.Add(mutant);
                }
                IComptes resultFile = new Comptes
                {
                    Version = ConfigHelper.Version,
                    DateExport = DateTime.Now,
                    ListComptes = listCompte
                };
                serialiseur = new XmlSerializer(typeof(Comptes));
                serialiseur.Serialize(file, resultFile);
            }
            var content = Encoding.UTF8.GetBytes(serialiseur.ToString());
            string title = comptesBdd.Count() > 1 ? "ExportComptesMultiple.xml" : string.Concat("ExportCompte_", comptesBdd.First().Id, ".xml");
            return (title, content);
        }
    }
}
