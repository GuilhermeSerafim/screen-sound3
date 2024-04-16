namespace ScreenSound.Modelos;

internal class Banda : IAvaliavel // Implementando a interface
{
    private List<Album> albuns = new();
    private List<Avaliacao> notas = new();
    public string Nome { get; }

    public Banda(string nome) => Nome = nome;

    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(itemNota => itemNota.Nota);
        }
    }

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }
    public void AdicionarNota(Avaliacao nota)
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
