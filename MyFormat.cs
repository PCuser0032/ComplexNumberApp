using ComplexArithmetic;

namespace MyFormatOutput
{
    internal class MyFormat
    {
        public static void GetResult(MyComplex num)
        {
            Console.WriteLine($"{ num.Re } { (num.Im < 0.0 ? '-' : '+') } { (num.Im < 0.0 ? Math.Abs(num.Im) : num.Im) }i");
        }

        public static string GetResultStr(MyComplex num)
        {
            return $"{ num.Re } { (num.Im < 0.0 ? '-' : '+') } { (num.Im < 0.0 ? Math.Abs(num.Im) : num.Im) }i";
        }

        // public static string GetResultStr(MyComplex num) => $"{ num.Re } { (num.Im < 0.0 ? '-' : '+') } { (num.Im < 0.0 ? Math.Abs(num.Im) : num.Im) }i";
    }
}
