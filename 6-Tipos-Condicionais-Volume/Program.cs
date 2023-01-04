// Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a fórmula:
// V = 3.14159 * R * R * A
// Onde as variáveis: V, R e A representam respectivamente o volume, o raio e a altura.

Console.WriteLine("Digite o valor do raio:");
int raio = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor da altura:");
int altura = Convert.ToInt32(Console.ReadLine());

double volume = 3.14159 * raio * raio *  altura;

Console.WriteLine("Volume: " + volume);
