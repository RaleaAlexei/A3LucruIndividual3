using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1.Classes
{
    internal class Salariat : Persoana
    {
        public int numarOreLucrat;
        public double platePeOra;
        public int anulAngajarii;
        public Salariat(Form1 form) : base(form)
        {

        }
        // Returneaza salariul cu 2 numere dupa virgula
        public double salariu() 
            => Math.Round(numarOreLucrat * platePeOra, 2);
        
        public int Citire()
        {
            base.Citire();
            int.TryParse(form.tbOreLucrate.Text, out numarOreLucrat);
            double.TryParse(form.tbPlataPeOra.Text, out platePeOra);
            int.TryParse(form.tbAnulAngajarii.Text, out anulAngajarii);
            return 1;
        }
        public int afisare()
        {
             
            return 1;
        }
    }
}
