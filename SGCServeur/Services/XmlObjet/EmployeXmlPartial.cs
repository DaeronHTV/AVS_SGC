using SGCServeur.Models;
using System;
using System.Collections.Generic;

namespace SGCServeur.Services
{
    public partial class Employes : IEmployes
    {
        public string Version 
        { 
            get => version;
            set => version = value; 
        }

        public DateTime DateExport 
        {
            get => dateExport;
            set => dateExport = value; 
        }

        IEnumerable<IEmploye> IEmployes.Employes 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
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
    }

    public partial class EmployesEmployeCompteSet : ICompte
    {
        string ICompte.Code 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        string ICompte.Mail 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        int ICompte.Indice 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        TypeCompteEnum ICompte.TypeCompte 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        DateTime ICompte.DateInsertion 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        DateTime ICompte.DateMaj 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
    }
}
