namespace ComplexArithmetic;

internal class MyComplex
{
    public double Re { get; set; }
    public double Im { get; set; }
    public static MyComplex Add(MyComplex x, MyComplex y)
    {
        MyComplex result = new MyComplex();

        result.Re = x.Re + y.Re;
        result.Im = x.Im + y.Im;

        return result;
    }

    public static MyComplex Subtract(MyComplex x, MyComplex y)
    {
        MyComplex result = new();

        result.Re = x.Re - y.Re;
        result.Im = x.Im - y.Im;

        return result;
    }
    public static MyComplex Multiply(MyComplex x, MyComplex y)
    {
        MyComplex result = new MyComplex
        {
            Re = x.Re * y.Re - x.Im * y.Im,
            Im = x.Re * y.Im + x.Im * y.Re
        };

        return result;
    }

    public static MyComplex Divide(MyComplex x, MyComplex y)
    {
        MyComplex result = new()
        {
            Re = (x.Re * y.Re + x.Im * y.Im) / (y.Re * y.Re + y.Im * y.Im),
            Im = (y.Re * x.Im - x.Re * y.Im) / (y.Re * y.Re + y.Im * y.Im)
        };

        return result;
    }
}
