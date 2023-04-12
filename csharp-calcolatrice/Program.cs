namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Somma di due numeri interi: {CalcoliHelper.SommaNum(2, 2)} \n \n" +
                $"Somma di due numeri decimali: {CalcoliHelper.SommaNum(2.5, 3.7)} \n \n" +
                $"Differenza fra due numeri interi: {CalcoliHelper.DifferenzaNum(2, 2)} \n \n" +
                $"Differenza fra due numeri decimali: {CalcoliHelper.DifferenzaNum(2.5, 3.7)} \n \n" +
                $"Prodotto fra due numeri interi: {CalcoliHelper.ProdottoNum(2, 2)} \n \n" +
                $"Prodotto fra due numeri decimali: {CalcoliHelper.ProdottoNum(2.5, 3.7)} \n \n" +
                $"Valore assoluto di un numero interi: {CalcoliHelper.ValAbsNum(-2)} \n \n" +
                $"Valore assoluto di un numero decimale: {CalcoliHelper.ValAbsNum(-2.5)} \n \n" +
                $"Valore minimo fra due numeri interi: {CalcoliHelper.MinNum(2, 4)} \n \n" +
                $"Valore minimo fra due numeri decimali: {CalcoliHelper.MinNum(2.5, 3.7)} \n \n" +
                $"Valore massimo fra due numeri interi: {CalcoliHelper.MaxNum(2, 4)} \n \n" +
                $"Valore massimo fra due numeri decimali: {CalcoliHelper.MaxNum(2.5, 3.7)} \n \n" +
                $"Potenza di un numero intero positivo: {CalcoliHelper.Eleva(2, 2)} \n \n" +
                $"Potenza di un numero intero negativo: {CalcoliHelper.Eleva(-2, -2)}");

        }
    }
}