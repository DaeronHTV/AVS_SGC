﻿using SGCServeur.LibrairieBdd;
using SGCServeur.Models.Bdd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGCServeur.Services
{
    public class ImportService
    {
        private SGCContext context;

        public ImportService(SGCContext context)
        {
            this.context = context;
        }
    }
}
