
namespace ScreenSound.Desafios.FormasGeometricas;

internal class CalcularFormaGeometrica
{
    public void EscolherForma()
    {
        Console.Write("Digite sua forma: ");
        string forma = Console.ReadLine()!;
        switch (forma)
        {
            case "triangulo":
                CalcularAreaEPerimetroTriangulo();
                break;
            case "quadrado":
                CalcularAreaEPerimetroQuadrado();
                break;
            case "circulo":
                CalcularAreaEPerimetroCirculo();
                break;
            default:
                break;
        }
    }

    private void CalcularAreaEPerimetroTriangulo()
    {
        Console.WriteLine("Calculo de área: ");
        Console.WriteLine("A=base×altura/2");
        Console.Write("Digite a base: ");
        int b = int.Parse(Console.ReadLine()!);
        Console.Write("Digite a altura: ");
        int h = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Área do respectivo triângulo: {b * h}");

        Thread.Sleep(2000);
        Console.Clear();

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
    }

    private void CalcularAreaEPerimetroQuadrado()
    {
        Console.WriteLine("Calculo de área: ");
        Console.WriteLine("A área (A) de um quadrado pode ser calculada pela fórmula: A=L^2");
        Console.Write("Digite o comprimento do quadrado: ");
        int l = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"A área do respectivo quadrado: {l ^ 2}");
        Thread.Sleep(3000);
        Console.WriteLine("O perímetro (P) de um quadrado é a soma dos comprimentos de todos os seus lados. Como um quadrado tem quatro lados iguais, o perímetro é dado por: P=4×L");
        Console.WriteLine($"Logo, o perímetro do respectivo quadrado é {l * 4}");
    }

    private void CalcularAreaEPerimetroCirculo()
    {
        Console.WriteLine("A área (A) de um círculo pode ser calculada pela fórmula: A=π×r");
        Console.WriteLine("r é o raio do círculo.");
        Console.WriteLine("O símbolo π (pi) é uma constante matemática que representa a relação entre a circunferência de um círculo e seu diâmetro, com um valor aproximado de \r\n3.14159\r\n3.14159.");
        Console.Write("Digite o raio do seu circulo: ");
        double raio = double.Parse(Console.ReadLine()!);
        double pi = 3.14;
        Console.WriteLine($"A área do seu circulo é: {(raio * raio) * pi}");
        Thread.Sleep(3000);
        Console.WriteLine("O perímetro (ou circunferência) de um círculo é dado pela fórmula: C=2π×r");
        Console.WriteLine($"Logo, o perímetro do respectivo circulo é {(pi * pi) * raio}");
    }
}
