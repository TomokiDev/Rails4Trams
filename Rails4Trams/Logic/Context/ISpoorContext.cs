﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams
{
   public interface ISpoorContext
    {
        List<Spoor> Zoekspoor(Tram tram);
        Spoor GetSpoor(int id);
    }
}
