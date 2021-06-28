using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ozn_prackt
{
    class okruzhnost
    {
        /* Разработка набора библиотек работы 
             с геометрическими данными Окружность, треугольник,
             прямоугольник, трапеция, параллелограмм 
             (стороны, углы, периметр, площадь)*/
        // площадь окружнсоти ПP^2
        // периметр окружности 2ПP
        // угол окружнсоти 360
        public double R =0;
        //public int S;
        public double S;
        public double P;
        public double L;

        public void Sp(double r)
        {
            
             S =3.14 * Math.Pow(r, 2); 
        }

        public void PP(double r)
        {

            P = 3.14 * R * 2;
        }

        public void UG()
        {

            L = 360.0;
        }


    }
}
