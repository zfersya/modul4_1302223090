using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302223090
{
    internal class KodeBuah
    {
        public enum NamaBuah
        {
            Apel,
            Aprikot,
            Alpukat,
            Pisang,
            Paprika,
            Blackberry,
            Ceri,
            Kelapa,
            Jagung
        }
        private string[] kodeBuah = {
            "A00",
            "B00",
            "C00",
            "D00",
            "E00",
            "F00",
            "H00",
            "I00",
            "J00"
        };
        public String GetKodeBuah(NamaBuah namaBuah)
        {
            int i = (int)namaBuah;
            if (i >= 0 && i < kodeBuah.Length)
            {
                return kodeBuah[i];
            }
            else
            {
                return "Kodebuah tidak tersedia";
            }
        }
    }
}
