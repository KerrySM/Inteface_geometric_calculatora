using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ozn_prackt
{
    class parallelogram
    {
        /* Разработка набора библиотек работы 
          с геометрическими данными Окружность, треугольник,
          прямоугольник, трапеция, параллелограмм 
          (стороны, углы, периметр, площадь)*/
        // площадь окружнсоти ПP^2
        // периметр окружности 2ПP
        // угол окружнсоти 360
        public int R = 0;
        //public int S;
        public double S;
        public double P;
        public double L;
        public double D;

         public double A1;
         public double B1;
        // public double C;



      


        public void Sp_PO_VIS(double A, double H)
        {

            S = A * H;
        }

        public void Sp_PO_DIAG(double d1, double d2, double alf)
        {

            S = 0.5*d1*d2 * Math.Sin(alf);
        }
        public void Sp_PO_ULGU_STORON(double A, double B,double alf)
        {

            S = (A * B)*(Math.Sin(alf));
        }

        public void PP(double A, double B)
        {

            P = 2*(A + B);
        }



        public void P_D(double A, double D1, double D2)
        {
            P= 2 * A + Math.Sqrt(2 * (Math.Pow(D1, 2)) + 2 * (Math.Pow(D2, 2)) - 4 * (Math.Pow(A, 2)));
             
        }




        //определение сторон

        public void a_po_diag_alf(double d1, double d2, double alf)
        {
            A1 = (Math.Sqrt(Math.Pow(d1, 2) + Math.Pow(d2, 2) + 2 * d1 * d2 * Math.Cos(alf)))/2;

        }


        public void a_po_diag_b(double d1, double d2, double b)
        {
            A1 = (Math.Sqrt(Math.Pow(d1, 2) + Math.Pow(d2, 2) - 4* Math.Pow(b, 2))) / 2;

        }

        public void a_po_h_alf(double h, double alf)
        {
            A1 = h / Math.Sin(alf);

        }


        public void a_po_S_H(double s, double h)
        {
            A1 = s / h;

        }

        //все углы прямоугольника равны 90 градусов
        public void UG(double pr_ug)
        {

            L = 180 - pr_ug;
        }
    }
}
