﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeretanaData;
using Shared.Models;

namespace TeretanaBusiness
{
    public class TrenerBusiness
    {
        TrenerRepository tRepo = new TrenerRepository();
        public  List<Trener> Proba()
        {
            return this.tRepo.PrijavaTrenera();
        }
        public bool InsertTrener(Trener t)
        {
            if(this.tRepo.InsertTrener(t)>0)
            {
                return true;
            }
            return false;
        }
    }
}
