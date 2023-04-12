using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    public static class CalcoliHelper
    {

        public static int SommaNum(int num1, int num2)
        {
            return num1 + num2;
        }
        public static double SommaNum(double num1, double num2)
        {
            return num1 + num2;
        }

        public static int DifferenzaNum(int num1, int num2)
        {
            return num1 - num2;
        }

        public static double DifferenzaNum(double num1, double num2)
        {
            return num1 - num2;
        }

        public static int ProdottoNum(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double ProdottoNum(double num1, double num2)
        {
            return num1 * num2;
        }

        public static int ValAbsNum(int num)
        {
            return Math.Abs(num);
        }

        public static double ValAbsNum(double num)
        {
            return Math.Abs(num);
        }

        public static int MinNum(int num1, int num2)
        {
            if (num1 < num2)
                return num1;
            else
                return num2;
        }

        public static double MinNum(double num1, double num2)
        {
            if (num1 < num2)
                return num1;
            else
                return num2;
        }

        public static int MaxNum(int num1, int num2)
        {
            if (num1 > num2)
                return num1;
            else
                return num2;
        }

        public static double MaxNum(double num1, double num2)
        {
            if (num1 > num2)
                return num1;
            else
                return num2;
        }

        public static int Eleva(int numBase, int esponente)
        {
            if (numBase == 0 && esponente == 0)
                return 1;

            else if (esponente == 0)
                return 1;

            else if (esponente < 0)
                return Eleva(1 / numBase, -esponente);

            else
            {
                int result = 1;
                for (int i = 0; i < esponente; i++)
                {
                    result *= numBase;
                }
                return result;
            }

        }
    }
}
