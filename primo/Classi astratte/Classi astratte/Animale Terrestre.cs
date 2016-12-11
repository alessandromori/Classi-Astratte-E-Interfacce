using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_astratte
{
    abstract class Animale_Terrestre : Animale
    {
        public Animale_Terrestre(string nome,int zampe):base(nome,"terrestre","terra",zampe )
        {
        }
    }
}
