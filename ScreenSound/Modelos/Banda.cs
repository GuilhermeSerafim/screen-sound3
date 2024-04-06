namespace ScreenSound.Modelos;

class Banda
{
    public Banda(string nome) => Nome = nome;

    private List<Album> albuns = new List<Album>();

    public string Nome { get; }

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
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
