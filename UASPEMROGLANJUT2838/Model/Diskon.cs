using System;
using System.Collections.Generic;
using System.Text;

namespace UASPEMROGLANJUT2838.Controller
{
    public class Diskon
    {
        public string diskon { get; set; }
        public double potongan { get; set; }

        public Diskon(string diskon, double potongan)
        {
            this.diskon = diskon;
            this.potongan = potongan;
        }
    }
}