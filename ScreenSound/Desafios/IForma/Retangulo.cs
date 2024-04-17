namespace ScreenSound.Desafios.IForma;

internal class Retangulo : IForma
{
    public double CalcularArea()
    {
        Console.WriteLine("Calculo de área: ");
        Console.WriteLine("A=base×altura/2");
        Console.Write("Digite a base: ");
        int b = int.Parse(Console.ReadLine()!);
        Console.Write("Digite a altura: ");
        int h = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Área do respectivo triângulo: {b * h}");
        return b * h;
    }

    public double CalcularPerimetro()
    {
        Console.WriteLine("Calculo de perimetro: ");
        Console.WriteLine("O perímetro (P) de um triângulo é a soma dos comprimentos de todos os seus lados.");
        Console.WriteLine("P=a+b+c");
        Console.Write("Digite o comprimento do lado A: ");
        int ladoA = int.Parse(Console.ReadLine()!);
        Console.Write("Digite o comprimento do lado B: ");
        int ladoB = int.Parse(Console.ReadLine()!);
        Console.Write("Digite o comprimento do lado C: ");
        int ladoC = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"O perimetro do respectivo triângulo: {ladoA + ladoB + ladoC}");
        return ladoA + ladoB + ladoC;
    }
}
