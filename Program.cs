// 

String Palavra1;
String Palavra2;
String Palavra3;

Console.WriteLine("----Alinmhando a Direita----");
Console.WriteLine();

Console.Write("Digite a Primeira palavra..:");
Palavra1 = Console.ReadLine()!.Trim();

Console.Write("Digite a segunda palavra..:");
Palavra2 = Console.ReadLine()!.Trim();

Console.Write("Digite a terceira palavra..:");
Palavra3 = Console.ReadLine()!.Trim();

Console.WriteLine();
Console.WriteLine($"{Palavra1.PadLeft(20, ' ')}");
Console.WriteLine($"{Palavra2.PadLeft(20, ' ')}");
Console.WriteLine($"{Palavra3.PadLeft(20, ' ')}");


