using SGCServeur.Models.Bdd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGCServeur.Services
{
    public class StatsService
    {
        private SGCContext context;

        public StatsService(SGCContext context)
        {
            this.context = context;
        }

        public object GetCompetencesStats()
        {

            return null;
        }
    }
}
