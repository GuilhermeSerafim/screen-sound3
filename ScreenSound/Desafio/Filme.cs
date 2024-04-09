namespace Alura.Filmes;

public class Filme
{
    public string Titulo { get; set; }
    public List<Artista> Elenco { get; set; }
    public int Duracao { get; set; }

    public Filme(string titulo, int duracao, List<Artista>? elenco)
    {
        if (elenco == null)
        {
            Elenco = new List<Artista>();
        }
        else
        {
            Elenco = elenco;
        }

        Titulo = titulo;
        Duracao = duracao;
    }

    public void AdicionarElenco(Artista artista)
    {
        Elenco.Add(artista);
        Console.WriteLine($"{artista} adicionado/a ao elenco.");
        Console.WriteLine("teste " + this);
        if (!artista.FilmesAtuados.Contains(this))
        {
            artista.AdicionarFilme(this);
        }
    }

    public void ListarElenco()
    {
        if (Elenco.Count == 0)
        {
            Console.WriteLine("Elenco vazio.");
        }
        else
        {
            Console.WriteLine("Elenco... ");
            foreach (var artista in Elenco)
            {
                Console.WriteLine(artista.Nome);
            }
        }
    }
}