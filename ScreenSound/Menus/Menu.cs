using ScreenSound.Modelos;
namespace ScreenSound.Menus;

internal class Menu
{
    Dictionary<string /*Nome da banda*/, Banda/*Propriedades da banda*/> bandasIniciais = new();

    public void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

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


    public void Executar()
    {
        // Verifica se as bandas iniciais já foram inseridas
        if (bandasIniciais.Count == 0)
        {
            // Se as bandas iniciais não foram inseridas, insere-as
            bandasIniciais = InserirBandasIniciais();
        }

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
                    MenuRegistrarBanda menu1 = new();
                    menu1.Executar(this.bandasIniciais);
                    Executar();
                    break;
                case 2:
                    MenuRegistrarAlbum menu2 = new();
                    menu2.Executar(this.bandasIniciais);
                    Executar();
                    break;
                case 3:
                    MenuExibirBandas menu3 = new();
                    menu3.Executar(this.bandasIniciais);
                    Executar();
                    break;
                case 4:
                    MenuAvaliarBanda menu4 = new();
                    menu4.Executar(this.bandasIniciais);
                    Executar();
                    break;
                case 5:
                    MenuExibirDetalhes menu5 = new();
                    menu5.Executar(this.bandasIniciais);
                    Executar();
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
            Console.Clear();
            Executar();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            Thread.Sleep(4000);
            Console.Clear();
            Executar();
        }
    }
    public Dictionary<string, Banda> InserirBandasIniciais()
    {
        // Bandas iniciais
        Banda ira = new("Ira!");
        ira.AdicionarNota(new Avaliacao(8));
        ira.AdicionarNota(new Avaliacao(9));
        ira.AdicionarNota(new Avaliacao(10));
        Banda ironMaiden = new("Iron Maiden");
        ironMaiden.AdicionarNota(new Avaliacao(10));
        this.bandasIniciais = new()
        {
            { ira.Nome, ira },
            { ironMaiden.Nome, ironMaiden }
         };
        return this.bandasIniciais;
    }
}
