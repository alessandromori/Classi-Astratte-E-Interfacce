using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_astratte
{
    abstract class Bipede : Animale_Terrestre
    {
        public Bipede(string nome): base(nome,2)
        { }
    }
}
