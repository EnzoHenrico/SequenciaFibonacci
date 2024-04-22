int final = 0, num1 = 1, num2 = 0, acc = 0;

Console.Write("Diga o indice de parada da sequencia de Fibonacci: ");
final = int.Parse(Console.ReadLine());

Console.WriteLine("Sequencia Fibonacci: ");
for (int i = 1; i <= final; i++)
{   
    acc = num1 + num2;
    num1 = num2;
    num2 = acc;
    Console.WriteLine(" " + num2);
}
