using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuExibirBandas : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        // Base refere-se aos membros da classe mãe
        base.Executar(bandasRegistradas); // Vai ser executado o Console.Clear();
        ExibirTituloDaOpcao("Bandas registradas:");
        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();

    }
}
