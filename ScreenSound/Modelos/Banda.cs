namespace ScreenSound.Modelos;

internal class Banda : IAvaliavel // Implementando a interface
{
    public List<Album> albuns = new();
    // Expõe o enumerador que dá suporte a uma iteração simples em uma coleção de um tipo especificado. (PROTEGENDO NOSSA LÓGICA)
    public IEnumerable<Album> Albuns => albuns; // Reduzindo acesso, pois list tem metodos que podem implicar na nossa regra de negocio (Clear por ex)
    private List<Avaliacao> notas = new();
    public string Nome { get; }

    // Inputado pelo Chatgpt
    public string? Resumo { get; set; }
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
        foreach (Album album in Albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome}\n");
            Console.WriteLine($"Duração do álbum em segundos: {album.DuracaoTotal}");
        }
    }
}
