using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1.Classes
{
    internal class Sofer : Persoana
    {
        public double distantaParcursa;
        public double platePerKM;
        public Sofer(Form1 form) : base(form)
        {

        }
        // Returneaza bursa cu 2 numere dupa virgula
        public double plata()
            => Math.Round(distantaParcursa * platePerKM);
        
        public int Citire()
        {
            base.Citire();
            double.TryParse(form.tbMedia.Text, out distantaParcursa);
            double.TryParse(form.tbGrupa.Text, out platePerKM);
            return 1;
        }
        public int afisare()
        {
            return 1;
        }
    }
}
