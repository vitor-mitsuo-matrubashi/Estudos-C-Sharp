using System;
using ExcelDna.Integration;

class Addin 
{
    public static class FuncoesFinancas 
    {
        [ExcelFunction(Description = "Soma dois números")]
        public static double Soma(double a, double b)
        {
            return a + b;
        }


    }


}
