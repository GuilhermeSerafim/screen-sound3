namespace Alura.Filmes;

public class Filme(string titulo, int duracao)
{
    public string Titulo { get; set; } = titulo;
    public List<Artista> Elenco { get; set; } = new List<Artista>();
    public int Duracao { get; set; } = duracao;

    public void AdicionarArtistaAoElenco(Artista artista)
    {

        if (artista.FilmesAtuados.Contains(this))
        {
            Console.WriteLine($"O artista {artista.Nome} já está no elenco do Filme {this.Titulo}\n");
        }
        else
        {
            // Consistência com a classe Artista
            artista.FilmesAtuados.Add(this); // Adicionando filme atuado
            // Poderia usar o this.Elenco ... (pq o this se refere ao objeto atual)
            Elenco.Add(artista); // Adicionando artista ao elenco (consistencia)
            // Exemplo: duna2.AdicionarArtistaAoElenco(zendaya) - O this seria o duna2, que e o objeto
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