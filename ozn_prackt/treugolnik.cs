using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ozn_prackt
{
    class treugolnik
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


       public double a;
        public double b;
        public double c;

        public double PolP;
        public double H;

        public double alf;
        public double bet;
        public double gam;


        public void PopePer(double A, double B, double C)
        {
            PolP = (A + B + C) / 2;


        }

        public void VIS(double A, double B, double C)
        {
            //PolP = 0;
            PopePer( A,  B,  C);
            H =(2/A)*Math.Sqrt(PolP*(PolP-A)*(PolP-B)*(PolP-C)); 
        }



        public void Sp(double A, double B , double C)
        {
            VIS(A,  B,  C);
            S = 0.5 * A * H;
        }

        public void PP(double A, double B, double C)
        {

            P = A+B+C;
        }

        public void kat_a_gip_cos(double C,double ALF)
        {
            a = C * Math.Cos(ALF);
           
        }

        public void kat_a_gip_SIN(double C, double ALF)
        {
            a = C * Math.Sin(ALF);

        }

        public void kat_a_b_tg(double B, double ALF)
        {
            a = B * Math.Tan(ALF);

        }

        public void gip_a_alf(double A, double ALF)
        {
            c = A / Math.Sin(ALF);

        }


        public void gip_a_bet(double A, double bet)
        {
            c = A / Math.Cos(bet);

        }


        public void gip_po_pif(double B, double A)
        {
            c = Math.Sqrt(Math.Pow(B, 2) + Math.Pow(A, 2));

        }

        public void KAT_po_pif(double C, double A)
        {
            b = Math.Sqrt(Math.Pow(C, 2) - Math.Pow(A, 2));

        }



        //для равнобедренного треугольника


        public void b_sin(double B, double ALF)
        {
            b = (2*B) * Math.Sin((alf / 2));

        }

        public void b_cos(double B, double ALF)
        {
            b = B * Math.Sqrt(2 - 2 * Math.Cos(ALF));

        }

        public void a_sin(double B, double ALF)
        {
            a = B / 2 * Math.Sin(alf / 2);

        }

        public void a_cos(double B, double ALF)
        {
            a = B / Math.Sqrt(2 - 2 * Math.Cos(ALF));

        }

        public void a_cos_bet(double B, double ALF)
        {
            a = B /2* Math.Cos(ALF);

        }
        public void UG(double A , double B , double C)
        {

            a = A;
            b = B;
            c = C;
            alf = Math.Acos(((a * a) + (c * c) - (b * b ))/ (2 * a * c));
            alf = (alf * 180) / Math.PI;

            bet = Math.Acos(((a * a) + (b*b)  - (c * c)) /( 2 * a * b));
            bet = (bet * 180) / Math.PI;

            gam = Math.Acos(((b * b )+ (c * c) - (a * a)) / (2 * b * c));
            gam = (gam * 180) / Math.PI;





        }
    }
}
