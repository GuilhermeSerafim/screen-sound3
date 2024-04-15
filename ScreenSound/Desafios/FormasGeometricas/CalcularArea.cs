namespace ScreenSound.Desafios.FormasGeometricas;

internal class CalcularArea
{
    public void EscolherForma()
    {
        Console.Write("Digite sua forma: ");
        string forma = Console.ReadLine()!;
        switch (forma)
        {
            case "triangulo":
                Console.WriteLine("Deseja calcular a área ou perimetro de um triangulo");
                var calculadoDesejado = Console.ReadLine();
                if(calculadoDesejado == "area")
                {
                    Console.WriteLine("O perímetro (P) de um triângulo é a soma dos comprimentos de todos os seus lados.");
                    Console.Write("Digite o lado A");
                    string ladoA = Console.ReadLine()!;
                    Console.Write("Digite o lado B");
                    string ladoB = Console.ReadLine()!;
                    Console.Write("Digite o lado C");
                    string ladoC = Console.ReadLine()!;
                    CalcularPerimetro(ladoA, ladoB, ladoC);
                }
                else if(calculadoDesejado == "perimetro")
                {

                } else
                {
                    Console.WriteLine("Erro");
                    return;
                }

                AreaCirculo areaCirculo = new AreaCirculo();
                areaCirculo.CalcularArea(calcCirculo!);
                break;
            case "quadrado":
                break;
            case "circulo":
                Console.WriteLine("Digite alguma coisa referente para calcula da area");
                var calcCirculo = Console.ReadLine(); 
                AreaCirculo areaCirculo = new();
                areaCirculo.CalcularArea(calcCirculo!);
                break;
            default:
                break;
        }
    }
    public void CalcularPerimetro(int a, int b, int c)
    {

    }
}
