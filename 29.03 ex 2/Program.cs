Console.BackgroundColor = ConsoleColor.Gray;
Console.WriteLine(@$"
-------------------
|programa do joao  |   
|calculo de média  |                 
-------------------
");
Console.ResetColor();


Console.WriteLine($"digite sua nota 1:");
int nota1 = int.Parse(Console.ReadLine());
Console.WriteLine($"digite sua nota 2:");
int nota2 = int.Parse(Console.ReadLine());
Console.WriteLine($"digite sua nota 3:");
int nota3 = int.Parse(Console.ReadLine());
Console.WriteLine($"digite sua nota 4:");
int nota4 = int.Parse(Console.ReadLine());
Console.WriteLine($"digite sua nota 5:");
int nota5 = int.Parse(Console.ReadLine());

float media = (nota1+nota2+nota3+nota4+nota5) /5;

Console.WriteLine($"sua nota média é: {media}");

