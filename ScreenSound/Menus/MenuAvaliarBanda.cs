using ScreenSound.Modelos;
using System;

namespace ScreenSound.Menus;

internal class MenuAvaliarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        // Base refere-se aos membros da classe mãe
        base.Executar(bandasRegistradas); // Vai ser executado o Console.Clear();
        ExibirTituloDaOpcao("Avaliar banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        // Ele verifica se a coleção contém uma chave específica (bool)
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda]; // Encapsulando para ter acesso aos metodos do mesmo
            Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
            Avaliacao avaliacao = Avaliacao.TextoParaAvaliacao(Console.ReadLine()!); // Como usei static, posso usar sem instanciar
            banda.AdicionarNota(avaliacao); // Acessando os metodos para adicionar nota (que encapsulamos na banda)
            Console.WriteLine($"\nA nota {avaliacao.Nota} foi registrada com sucesso para a banda {nomeDaBanda}");
            Thread.Sleep(2000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
