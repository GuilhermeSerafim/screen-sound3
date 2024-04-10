namespace Alura.Filmes;

public class Filme(string titulo, int duracao)
{
    public string Titulo { get; set; } = titulo;
    public List<Artista> Elenco { get; set; } = new List<Artista>();
    public int Duracao { get; set; } = duracao;

    public void AdicionarElenco(Artista artista)
    {

        if (artista.FilmesAtuados.Contains(this))
        {
            Console.WriteLine($"O artista {artista.Nome} já está no elenco do Filme {this.Titulo}\n");
        }
        else if (!artista.FilmesAtuados.Contains(this))
        {
            Console.WriteLine($"{artista.Nome} adicionado/a ao elenco do Filme {this.Titulo}.\n");
            // Consistência com a classe Artista
            artista.AdicionarFilme(this);
        }
        else
        {
            Console.WriteLine("Abobrinha");
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
            Console.WriteLine($"Elenco do filme {this.Titulo}");
            foreach (var artista in Elenco)
            {
                Console.WriteLine(artista.Nome);
            }
        }
    }
}