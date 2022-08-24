// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int x = 9, z = 6; double y = 8;               
Console.WriteLine(x-- == y);            // False
Console.WriteLine(x == (int)y);         // true
Console.WriteLine("{0:F1}", 0.123);     //0,1
Console.WriteLine(z / y);               //0,75
Console.WriteLine(x -= 10);             //-2
Console.WriteLine(x-- == y & true);     //false
Console.WriteLine(!(z == 6) | false);   //false
Console.WriteLine((x *= -2) == z);      // true

