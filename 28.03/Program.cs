//entrada
string nome = "joao";
int idade = 18;
float peso = 58;
float altura = 1.74f;

//processamento
float imc = peso / (altura * altura);

//saída
Console.WriteLine($"O IMC do " + nome + " é de : " + Math.Round(imc,2));
