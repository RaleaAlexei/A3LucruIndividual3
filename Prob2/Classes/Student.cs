using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1.Classes
{
    internal class Student : Persoana
    {
        public double mediaNotelor;
        public string grupa;
        public Student(Form1 form) : base(form)
        {

        }
        // Returneaza bursa cu 2 numere dupa virgula
        public double bursa()
            => mediaNotelor >= 7.5 ? 
                Math.Round(mediaNotelor * 75, 2) : 0;
        
        public int Citire()
        {
            base.Citire();
            double.TryParse(form.tbMedia.Text, out mediaNotelor);
            grupa = form.tbGrupa.Text;
            return 1;
        }
        public int afisare()
        {
            return 1;
        }
    }
}
