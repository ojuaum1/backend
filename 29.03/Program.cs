// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// //entrada
// string nome = "joao";
// int idade = 18;
// float peso = 58;
// float altura = 1.74f;

// //processamento
// float imc = peso / (altura * altura);

// //saída
// Console.WriteLine($"O IMC do " + nome + " é de : " + Math.Round(imc,2));

//só exemplo 
// Console.Write($"digite a altura do paciente:");
// double altura = double.Parse(Console.ReadLine()) ;

Console.BackgroundColor = ConsoleColor.Gray;
Console.WriteLine(@$"
-------------------
|programa do joao  |   
|calculo imc       |                 
-------------------
");
Console.ResetColor();




Console.Write($"digite o nome do paciente:");
string nome = Console.ReadLine();



Console.Write($"digite o peso do paciente:");
float peso = float.Parse(Console.ReadLine()) ;





Console.Write($"digite a altura do paciente:");
float altura = float.Parse(Console.ReadLine()) ;

float imc = peso / (altura * altura);

Console.WriteLine($"o paciente{nome} tem o imc igual á:{imc}");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"obrigado por usar o programa do hugo... hugostoso");
Console.ResetColor();



