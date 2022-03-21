using ComplexArithmetic;
using MyFormatOutput;

Console.WriteLine("Complex number arithmetic implementation on C#.");
Console.WriteLine("Created by Kozlov D., group VPI-31.");

MyComplex a = new MyComplex() { Re = 3.0, Im = 7.0 };
MyComplex b = new MyComplex() { Re = 2.0, Im = 3.0 };
MyComplex c = new() { Re = 20.0, Im = 47.0 };
MyComplex d = new() { Re = 4.0, Im = 11.0 };

Console.Write("a Addition b : "); MyFormat.GetResult(MyComplex.Add(a, b));

Console.Write("a Subtract b : "); MyFormat.GetResult(MyComplex.Subtract(a, b));

Console.Write("a Multiply b : "); MyFormat.GetResult(MyComplex.Multiply(a, b));

Console.Write("a Divide b : "); MyFormat.GetResult(MyComplex.Divide(a, b));

Console.WriteLine("c addition d : " + MyFormat.GetResultStr(MyComplex.Add(c, d)));

// Console.WriteLine($"a Divide b : { (object)c.Re } { sign } {(object)c.Im }i");

/*
 * Инициализация объекта:
 * MyComplex result = new MyComplex();
 * 
 * result.Re = x.Re + y.Re;
 * result.Im = x.Im + y.Im;
 * 
 * return result;
 * 
 */