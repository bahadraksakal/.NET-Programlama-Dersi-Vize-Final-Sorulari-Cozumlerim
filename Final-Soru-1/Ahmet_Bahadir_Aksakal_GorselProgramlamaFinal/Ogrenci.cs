using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahmet_Bahadir_Aksakal_GorselProgramlamaFinal
{
    internal class Ogrenci : Kisi
    {
        string sinif;
        public Ogrenci(string ad, string soyAd, string tel,string sinif) : base(ad, soyAd, tel)
        {
            this.sinif = sinif;
        }
    }
}
