using OpenAI_API;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarBanda : Menu
{
    public override async void Executar(Dictionary<string, Banda> bandasRegistradas)
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

        // Parte do chagpt
        var client = new OpenAIAPI("hashapi");

        var chat = client.Chat.CreateConversation();

        chat.AppendSystemMessage($"Resuma a banda {nomeDaBanda} em 1 parágrafo. Adote um estilo informal");

        string resposta = await chat.GetResponseFromChatbotAsync();
        banda.Resumo = resposta;
        // Tiramos isso pq a requsição em si ja demora um pouco
        //Thread.Sleep(4000);
        Console.Clear();;
    }
}
