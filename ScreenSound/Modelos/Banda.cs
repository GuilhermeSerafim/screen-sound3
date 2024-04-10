namespace ScreenSound.Modelos;

internal class Banda
{
    private List<Album> albuns = new();
    private List<int> notas = new();
    public string Nome { get; }

    public Banda(string nome) => Nome = nome;

    public double Media => notas.Average();

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }
    public void AdicionarNota(int nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome}\n");
            Console.WriteLine($"Duração do álbum em segundos: {album.DuracaoTotal}");
        }
    }
}
