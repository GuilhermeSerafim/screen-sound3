namespace ScreenSound.Desafios.IForma;

internal class Circulo : IForma
{
    public double CalcularArea()
    {
        Console.WriteLine("A área (A) de um círculo pode ser calculada pela fórmula: A=π×r");
        Console.WriteLine("r é o raio do círculo.");
        Console.WriteLine("O símbolo π (pi) é uma constante matemática que representa a relação entre a circunferência de um círculo e seu diâmetro, com um valor aproximado de \r\n3.14159\r\n3.14159.");
        Console.Write("Digite o raio do seu circulo: ");
        double raio = double.Parse(Console.ReadLine()!);
        double pi = 3.14;
        Console.WriteLine($"A área do seu circulo é: {(raio * raio) * pi}");
        return (raio * raio) * pi;
    }

    public double CalcularPerimetro()
    {
        Console.Write("Digite o raio do seu circulo: ");
        double raio = double.Parse(Console.ReadLine()!);
        double pi = 3.14;
        Console.WriteLine("O perímetro (ou circunferência) de um círculo é dado pela fórmula: C=2π×r");
        Console.WriteLine($"Logo, o perímetro do respectivo circulo é {(pi * pi) * raio}");
        return (pi * pi) * raio;
    }
}
