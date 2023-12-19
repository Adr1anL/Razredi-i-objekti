using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class BeogradskiNeboderi
    {
        double visina;
        int brojKatova;

        public double Visina { get => visina; set => visina = value; }
        public int BrojKatova { get => brojKatova; set => brojKatova = value; }

        public BeogradskiNeboderi(double visina, int brojKatova)
        {
            this.Visina = visina;
            this.BrojKatova = brojKatova;
        }

        public BeogradskiNeboderi()
        {
            this.Visina = visina;
            this.BrojKatova = brojKatova;
        }

        public override string ToString()
        {
            visina = visina + 10;

            brojKatova = brojKatova + 1;

            double prosjek = visina / brojKatova;

            string beograd = "Visina: " + visina + " m\nBroj katova: " + brojKatova + "\nProsječna visina kata: " + prosjek + " m";

            return beograd;
        }
    }
}
