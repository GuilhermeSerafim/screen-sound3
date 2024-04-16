using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Avaliar album");
        Console.Write("Digite a banda do album a ser avaliado: ");
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
                Console.WriteLine(item.Nome);
            }
            Console.WriteLine("Agora digite o título do álbum: ");
            string tituloDoAlbum = Console.ReadLine()!;
            // Mudança implementada, pois queremos entrar aqui apenas quando o titulo do album digitado existe dentro da lista de albuns da banda
            // Em geral, Any é usado quando você precisa determinar se há pelo menos um elemento em uma coleção que atende a certos critérios,
            // evitando assim a necessidade de percorrer toda a coleção se a condição for atendida cedo.
            // retorna true ou false
            if (banda.albuns.Any(album => album.Nome.Equals(tituloDoAlbum))) // Equals de string compara os valores das strings, não apenas suas referências de memória.
            {
                // O método First retorna o primeiro elemento que satisfaz a condição especificada em uma sequência.
                // Pegamos o album que queremos avaliar
                Album album = banda.albuns.First(album => album.Nome.Equals(tituloDoAlbum));
                Console.Write($"Qual a nota que o álbum {album.Nome} merece: ");
                Avaliacao nota = Avaliacao.TextoParaAvaliacao(Console.ReadLine()!); // Como usei static, posso usar sem instanciar
                album.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o álbum {tituloDoAlbum}");
                Thread.Sleep(3000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nO album {tituloDoAlbum} não foi encontrado!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
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
