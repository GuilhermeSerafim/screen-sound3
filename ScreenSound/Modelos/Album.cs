// Um namespace é um contêiner que agrupa um conjunto de classes, structs, interfaces, enums e outros namespaces relacionados logicamente.
// Ele é usado para organizar e evitar conflitos de nome entre os tipos em um projeto.
namespace ScreenSound.Modelos;

internal class Album : IAvaliavel
{
    public static int ContadorDeObjetos = 0;
    private List<Musica> musicas = new List<Musica>();
    // Primeiro tenho que guardar uma lista que adiciona essas notas
    private List<Avaliacao> notas = new();
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(musica => musica.Duracao); //     Soma das músicas

    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(itemNota => itemNota.Nota);
        }
    }

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

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }
}