Calculadora calc = new Calculadora();
Console.WriteLine("Digite o valor de X");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor e Y");
double y = Convert.ToDouble(Console.ReadLine());

double resultadoSoma = calc.Soma(x,y);
Console.WriteLine($"A soma de {x} e {y} é: {resultadoSoma}");

Console.WriteLine($"O resulatado da subtração é: {calc.Subtracao(x,y)}");

Console.WriteLine($"O resultado da multiplicação é: {calc.Multiplicar(x,y)}");
Console.WriteLine($"O resultado da divisão é: {calc.Divisao(x,y)}");