// Um namespace é um contêiner que agrupa um conjunto de classes, structs, interfaces, enums e outros namespaces relacionados logicamente.
// Ele é usado para organizar e evitar conflitos de nome entre os tipos em um projeto.
namespace ScreenSound.Modelos;

internal class Album
{
    public static int ContadorDeObjetos = 0;
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(musica => musica.Duracao); //     Soma das músicas

    public void AdicionarMusica(Musica musica)
    {
        // Posso adicionar lógicas internas aqui
        musicas.Add(musica);
    }
    public Album(string nome)
    {
        Nome = nome;
        // Toda vez que um album for criado, será incrementado
        ContadorDeObjetos++;
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Exibindo músicas do album {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"Duração total em segundos do álbum {Nome}: {DuracaoTotal}s");
    }
}