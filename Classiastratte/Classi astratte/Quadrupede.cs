using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_astratte
{
    abstract class Quadrupede : Animale_Terrestre
    {
        public Quadrupede(string nome) : base(nome, 4)
        { }
    }
}
