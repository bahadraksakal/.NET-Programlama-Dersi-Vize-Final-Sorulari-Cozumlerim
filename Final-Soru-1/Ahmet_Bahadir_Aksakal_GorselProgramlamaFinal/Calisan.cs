using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahmet_Bahadir_Aksakal_GorselProgramlamaFinal
{
    internal class Calisan:Kisi
    {
        string kurum;
        public Calisan(string ad, string soyAd, string tel,string kurum) : base(ad, soyAd, tel)
        {
            this.kurum = kurum;
        }
    }
}
