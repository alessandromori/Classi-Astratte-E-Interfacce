using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_astratte
{
    class Cavallo : Quadrupede
    {
        public Cavallo() : base("Cavallo")
        { }
        public override string StampaMovimento()
        {
            return "trotta";
        }
    }
}
