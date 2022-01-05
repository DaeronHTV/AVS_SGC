using SGC.Export.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGC.Export.Structure
{
    public partial class Employes : IEmployes
    {
        private List<IEmploye> employes = null;

        IEnumerable<IEmploye> IEmployes.Employes 
        {
            get
            {
                if(employes != null)
                {
                    List<IEmploye> emps = new List<IEmploye>();
                    foreach(IEmploye _ in Employe)
                    {
                        emps.Add(_);
                    }
                }
                return employes;
            }
            set
            {
                employes = value.ToList();
                //this.Employe = employes.ToArray();
                //TODO
            } 
        }
    }

    public partial class EmployesEmploye : IEmploye
    {
        string IEmploye.Code {
            get => codeField;
            set => codeField = value; 
        }

        string IEmploye.Libelle { 
            get => libelleField; 
            set => libelleField = value; 
        }

        string IEmploye.Description { 
            get => descriptionField; 
            set => descriptionField = value; 
        }

        public DateTime DateInsertion { 
            get => dateInsertionField; 
            set => dateInsertionField = value; 
        }

        public DateTime DateMaj { 
            get => dateMajField; 
            set => dateMajField = value; 
        }

        public ICompte Compte {
            get => compteSetField;
            set => compteSetField = new EmployesEmployeCompteSet
            {
                code = value.Code,
                mail = value.Mail,
                dateInsertion = value.DateInsertion,
                dateMaj = value.DateMaj,
                typeCompte = TypeCompteHelper.GetStringValueFromEnum(value.TypeCompte)
            }; 
        }
        public IEnumerable<IEmploi> Emplois 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public IEnumerable<ICompetence> Competences 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public IEnumerable<IConnaissance> Connaissances 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
    }

    public partial class EmployesEmployeCompteSet : ICompte
    {
        string ICompte.Code 
        {
            get => code; 
            set => code = value; 
        }

        string ICompte.Mail 
        { 
            get => mail; 
            set => mail = value; 
        }

        int ICompte.Indice 
        { 
            get => throw new NotImplementedException("Property doesn't exist !"); 
            set => throw new NotImplementedException("Property doesn't exist !"); 
        }
        TypeCompteEnum ICompte.TypeCompte 
        { 
            get => TypeCompteHelper.GetValueFromString(typeCompte); 
            set => typeCompte = TypeCompteHelper.GetStringValueFromEnum(value); 
        }

        DateTime ICompte.DateInsertion 
        { 
            get => dateInsertion; 
            set => dateInsertion = value; 
        }

        DateTime ICompte.DateMaj 
        { 
            get => dateMaj; 
            set => dateMaj = value; 
        }
    }
}
