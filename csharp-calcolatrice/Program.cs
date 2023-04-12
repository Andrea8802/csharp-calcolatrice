namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1)" + CalcoliHelper.SommaNum(2, 2));
            Console.WriteLine("2)" + CalcoliHelper.SommaNum(2.5, 3.7));

            Console.WriteLine("3)" + CalcoliHelper.DifferenzaNum(2, 2));
            Console.WriteLine("4)" + CalcoliHelper.DifferenzaNum(2.5, 3.7));

            Console.WriteLine("5)" + CalcoliHelper.ProdottoNum(2, 2));
            Console.WriteLine("6)" + CalcoliHelper.ProdottoNum(2.5, 3.7));

            Console.WriteLine("7)" + CalcoliHelper.ValAbsNum(-2));
            Console.WriteLine("8)" + CalcoliHelper.ValAbsNum(-2.5));

            Console.WriteLine("9)" + CalcoliHelper.MinNum(2,4));
            Console.WriteLine("10)" + CalcoliHelper.MinNum(2.5, 3.7));

            Console.WriteLine("11)" + CalcoliHelper.MaxNum(2, 4));
            Console.WriteLine("12)" + CalcoliHelper.MaxNum(2.5, 3.7));


        }
    }
}