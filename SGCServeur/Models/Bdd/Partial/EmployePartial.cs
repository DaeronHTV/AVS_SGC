using System.Linq;

namespace SGCServeur.Models.Bdd
{
    public partial class Employe
    {
        private Emploi currentEmploi = null;

        Emploi CurrentEmploi
        {
            get
            {
                if(currentEmploi == null)
                {
                    currentEmploi = Employeemplois.Where(emploi => emploi.Datefin == null).FirstOrDefault().Emploi;
                }
                return currentEmploi;
            }
        }
    }
}
