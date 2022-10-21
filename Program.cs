using System;

var var1 = Console.ReadLine();
var var2 = Console.ReadLine();
var var3 = Console.ReadLine();
var var4 = Console.ReadLine();
var Result1 = Int32.Parse(var1);
var Result2 = Int32.Parse(var2);
var Result3 = Int32.Parse(var3);
var Result4 = Int32.Parse(var4);
//int Result5 = new Overload().Method1(Int32.Parse(var1,var2,var3,var4));
//int Result6 = new Overload().Method2(Int32.Parse(var3));

Console.WriteLine($"Result Max {Method1(Result1, Result2)}");
Console.WriteLine($"Result Min {Method2(Result1, Result2)}");
Console.WriteLine($"Result even or odd?, {Method3(Result1, Result2)}");
Console.WriteLine($"Result Max {new Overload().Method1(Result1, Result2, Result3, Result4)}");
Console.WriteLine($"Result Max {new Overload().Method2(Result1, Result2, Result3, Result4)}");


int Method1(int m1, int m2)
{
    return (Math.Max(m1, m2));
}
int Method2(int m1, int m2)
{
    return (Math.Min(m1, m2));
}
string Method3(int m1, int m2)
{
    if ((m1 + m2) % 2 == 0)
        return $"true(odd), result is {var1 + var2}";
    return $"false(even), result is {var1 + var2}";
}

public class Overload
{
    public int Method1(int m1, int m2, int m3, int m4)
    {
        return Math.Max((Math.Max((Math.Max(m1, m2)), m3)), m4);
        
    }

    public int Method2(int m1, int m2, int m3, int m4)
    {
        return Math.Min((Math.Min((Math.Min(m1, m2)), m3)), m4);
        Console.WriteLine($"Result Max {Method2(m1, m2, m3, m4)}");
    }


}


/*


using System;

var var1 = Console.ReadLine();
var var2 = Console.ReadLine();
var var3 = Console.ReadLine();
var isCorrect = Int32.Parse(var1);
var isCorrect1 = Int32.Parse(var2);
var isCorrect2 = Int32.Parse(var3);


//Console.WriteLine($"Result Max {Method1( тут первая переменная должна быть стринг, вторая инт)}");
Console.WriteLine($"Result Max {Method1(isCorrect, isCorrect1)}");
//Console.WriteLine($"Result Min {Method2(обе инт)}");
//Console.WriteLine($"Result even or odd?, {Method3(обе инт)}");



string Method1(int m1, int m2)
{

    return (Math.Max(m1, m2)).ToString(); //Math.Max(int1, int2);
}



/*




using System;
 



Console.WriteLine($"Result Max {Method1()}");
Console.WriteLine($"Result Min {Method2()}");
Console.WriteLine($"Result even or odd?, {Method3()}");



int Method1(int var1 = 5, int var2 = 10)
{


    return Math.Max(var1, var2); //Math.Max(int1, int2);
}

int Method2(int var1 = 15, int var2 = 10)
{

    return Math.Min(var1, var2);

}
string Method3(int var1 = 3, int var2 = 5)
{
    if ((var1 + var2) % 2 == 0) return $"true, result is {var1+var2}";

        return $"false, result is {var1+var2}";
}*/
