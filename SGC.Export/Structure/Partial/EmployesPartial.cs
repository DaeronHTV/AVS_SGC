using SGC.Export.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGC.Export.Structure
{
    public partial class Employes : IEmployes
    {
        private List<IEmploye> employes = null;

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
            get => Employe;
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
        #region Property
        private List<IEmploi> emplois = null;
        private List<IConComCommon> connaissances = null;
        private List<IConComCommon> competences = null;
        #endregion

        public string Code
        {
            get => code;
            set => code = value;
        }

        public string Libelle
        {
            get => libelle;
            set => libelle = value;
        }

        public string Description
        {
            get => descriptionField;
            set => descriptionField = value;
        }

        public DateTime DateInsertion
        {
            get => dateInsertionField;
            set => dateInsertionField = value;
        }

        public DateTime DateMaj
        {
            get => dateMajField;
            set => dateMajField = value;
        }

        public ICompte Compte
        {
            get => compteSetField;
            set => compteSetField = new EmployesEmployeCompteSet
            {
                code = value.Code,
                mail = value.Mail,
                dateInsertion = value.DateInsertion,
                dateMaj = value.DateMaj,
                typeCompte = value.TypeCompte
            };
        }

        public IEnumerable<IEmploi> Emplois
        {
            get
            {
                return EmploisSet;
            }
            set => throw new NotImplementedException();
        }

        public IEnumerable<IConComCommon> Competences
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public IEnumerable<IConComCommon> Connaissances
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
    }

    public partial class EmployesEmployeCompteSet : ICompte
    {
        public string Code
        {
            get => code;
            set => code = value;
        }

        public string Mail
        {
            get => mail;
            set => mail = value;
        }

        public string TypeCompte
        {
            get => typeCompte;
            set => typeCompte = value;
        }

        public DateTime DateInsertion
        {
            get => dateInsertion;
            set => dateInsertion = value;
        }

        public DateTime DateMaj
        {
            get => dateMaj;
            set => dateMaj = value;
        }
    }

    public partial class EmployesEmployeEmploi : IEmploi
    {
        public DateTime DateDebut
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public DateTime DateFin
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        IEnumerable<IConComBase> IObjetEmploi.Connaissances
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        IEnumerable<IConComBase> IObjetEmploi.Competences
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
    }
}
