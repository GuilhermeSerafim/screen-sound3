using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        // Base refere-se aos membros da classe mãe
        base.Executar(bandasRegistradas); // Vai ser executado o Console.Clear();

        ExibirTituloDaOpcao("Registrar banda");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        // Como aqui não são bandas iniciais, quem vai digitar o nome da banda é o user, então vamos encapsular a resposta no construtor
        Banda banda = new(nomeDaBanda);
        bandasRegistradas.Add(banda.Nome, banda);
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();;
    }
}
