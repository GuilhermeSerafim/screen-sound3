namespace ScreenSound.Modelos;

class Banda
{
    public Banda(string nome) => Nome = nome;

    public double Media => notas.Average();

    // Lista de albuns da Banda
    private List<Album> albuns = new();

    private List<int> notas = new();

    public string Nome { get; }

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
