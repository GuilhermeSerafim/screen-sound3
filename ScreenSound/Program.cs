// A declaração using é para usar o namespace sem declarar o mesmo toda vez
using ScreenSound.Menus;
using ScreenSound.Modelos;

// Bandas iniciais
Banda iraInicial = new("Ira!");
iraInicial.AdicionarNota(new Avaliacao(8));
iraInicial.AdicionarNota(new Avaliacao(9));
iraInicial.AdicionarNota(new Avaliacao(10));
Banda beatlesInicial = new("The Beatles");

// Dictionary<TKey, TValue>
// Ou seja a chave seria o nome da banda (disponivel no construtor) e o valor seria o objeto banda, no qual teremos acesso aos metodos, entre outros
Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(iraInicial.Nome, iraInicial);
bandasRegistradas.Add(beatlesInicial.Nome, beatlesInicial);

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para exibir a media de notas de uma banda");
    Console.WriteLine("Digite -1 para sair");
    try
    {

        Console.Write("\nDigite a sua opção: ");
        string opcaoEscolhida = Console.ReadLine()!;
        int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

        switch (opcaoEscolhidaNumerica)
        {
            case 1:
                RegistrarBanda();
                break;
            case 2:
                RegistrarAlbum();
                break;
            case 3:
                MostrarBandasRegistradas();
                break;
            case 4:
                MenuAvaliarBanda menu4 = new();
                menu4.Executar(bandasRegistradas);
                ExibirOpcoesDoMenu();
                break;
            case 5:
                MenuExibirDetalhes menu5 = new();
                menu5.Executar(bandasRegistradas);
                ExibirOpcoesDoMenu();
                break;
            case -1:
                Console.WriteLine("Tchau tchau :)");
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Por favor, insira uma opção válida (número).");
        Thread.Sleep(3000);
        ExibirOpcoesDoMenu();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        Thread.Sleep(4000);
        ExibirOpcoesDoMenu();
    }

}

void RegistrarAlbum()
{
    Console.Clear();
    Console.Write("Digite a banda cujo álbum deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write("Agora digite o título do álbum: ");
        string tituloAlbum = Console.ReadLine()!;
        Banda banda = bandasRegistradas[nomeDaBanda];
        //Essa linha de código cria uma nova instância (usando o construtor que recebe o nome do album)
        // da classe Album e a adiciona à lista de álbuns da banda.
        banda.AdicionarAlbum(new Album(tituloAlbum));
        Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
    ExibirOpcoesDoMenu();
}

void RegistrarBanda()
{
    Console.Clear();
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    // Como aqui não são bandas iniciais, quem vai digitar o nome da banda é o user, então vamos encapsular a resposta no construtor
    Banda banda = new(nomeDaBanda);
    bandasRegistradas.Add(banda.Nome, banda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}

ExibirOpcoesDoMenu();