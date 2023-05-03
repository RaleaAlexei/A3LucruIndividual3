using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1.Classes
{
    internal class Persoana
    {
        public string Nume = string.Empty;
        public string Prenume = string.Empty;
        public int Anul = 0;
        public string CNP = string.Empty;
        protected readonly Form1 form;
        public Persoana(Form1 form)
        {
            this.form = form;
        }
        public int Citire()
        {
            Nume = form.tbNume.Text;
            Prenume = form.tbPrenume.Text;
            int.TryParse(form.tbAnulNasterii.Text, out Anul);
            CNP = form.tbCNP.Text;
            return 1;
        }
        public int Afisare()
        {
            return 1;
        }
    }
}
