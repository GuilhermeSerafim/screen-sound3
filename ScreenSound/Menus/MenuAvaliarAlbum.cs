using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Avaliar album");
        Console.Write("Digite o nome da banda que você quer avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        // Ele verifica se a coleção contém uma chave específica (bool)
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda]; // Encapsulando para ter acesso aos metodos do mesmo
            // Filtramos a banda
            // Próxima etapa séria pegarmos o album
            Console.WriteLine($"Albuns disponíveis da banda {banda.Nome}");
            foreach (var item in banda.albuns)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Agora digite o título do álbum: ");
            string tituloDoAlbum = Console.ReadLine()!;
            if (banda.albuns.Count > 0)
            {
                Console.Write($"Qual a nota que o álbum {tituloDoAlbum} merece: ");
                Avaliacao nota = Avaliacao.TextoParaAvaliacao(Console.ReadLine()!); // Como usei static, posso usar sem instanciar
                Album album = ???
                album.AdicionarNota(nota);
                banda.AdicionarNota(nota); // Acessando os metodos para adicionar nota (que encapsulamos na banda)
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a banda {tituloDoAlbum}");
                Thread.Sleep(2000);
                Console.Clear();
            }
            
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
