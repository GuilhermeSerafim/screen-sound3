namespace ScreenSound.Modelos;

internal class Banda
{
    private List<Album> albuns = new();
    private List<Avaliacao> avaliacoes = new();
    public string Nome { get; }

    public Banda(string nome) => Nome = nome;

    public double Media
    {
        get
        {
            if (avaliacoes.Count == 0) return 0;
            else return avaliacoes.Average(avaliacao => avaliacao.Nota);
        }
    }

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }
    public void AdicionarNota(Avaliacao avaliacao)
    {
        avaliacoes.Add(avaliacao);
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
