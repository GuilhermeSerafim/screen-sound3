using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarMusica : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Avaliar música");

        Console.Write("Digite a banda da música a ser avaliada: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];

            Console.WriteLine($"Músicas disponíveis da banda {banda.Nome}");
            foreach (var item in banda.musicas) // Como eu pego todas as musicas da banda? Sendo que n tem list? Tenho que criar, correto?
            {

            }
        }

    }
}
