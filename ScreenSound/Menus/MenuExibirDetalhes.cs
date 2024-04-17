using ScreenSound.Modelos;

namespace ScreenSound.Menus;


internal class MenuExibirDetalhes : Menu
{

    // O metodo Executar está se reescrevendo, pois temos o metodo Executar também no Program.cs
    // Override - agora estamos indicando que o metodo será sobreescrito
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        // Base refere-se aos membros da classe mãe
        base.Executar(bandasRegistradas); // Vai ser executado o Console.Clear();
        ExibirTituloDaOpcao("Exibir detalhes da banda");
        Console.Write("Digite o nome da banda: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine(banda.Resumo);
            Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");
            Console.WriteLine("\n Discografia -> Media do album");
            foreach (Album album in banda.Albuns)
            {
                Console.WriteLine($"{album.Nome} -> {album.Media}");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        }
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}

