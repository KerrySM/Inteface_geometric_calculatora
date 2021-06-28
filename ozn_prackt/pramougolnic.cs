using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ozn_prackt
{
    class pramougolnic
    {

        /* Разработка набора библиотек работы 
           с геометрическими данными Окружность, треугольник,
           прямоугольник, трапеция, параллелограмм 
           (стороны, углы, периметр, площадь)*/
        // площадь окружнсоти ПP^2
        // периметр окружности 2ПP
        // угол окружнсоти 360
        
        //public int S;
        public double S;
        public double P;
        public double L;
        public double D;

         public double a;
         public double b;
         public double c;
        public double d;





        public void Sp(double A, double B)
        {
           
            S = A*B;
            a = A;
            b = B;
        }

        public void PP(double A, double B)
        {
            a = A;
            b = B;
            storon(A,B);
            P = a + b + c+d;
        }


        public void storon(double A, double B)
        {
            a = A;
            b = B;
            c = a;
            d = b;
           // P = A + B + C + D;
        }

        //недоделано нет определения сторон


        //все углы прямоугольника равны 90 градусов
        public void UG()
        {

            L = 90;
        }
    }
}
