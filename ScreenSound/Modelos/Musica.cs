namespace ScreenSound.Modelos;

class Musica
{
    // Passando parametros do construtor que faz sentido para o objeto
    // O construtor faz sentido quando queremos iniciar um objeto com propriedades obrigatórias ou opcionais 
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    // Construtor

    // Variaveis
    public string Nome { get; }
    public Banda Artista { get; } // Tiramos o set, pois nós vamos setar o valor na construção da instância
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    // Expressão Lambda (get sucinto)
    private string DescricaoResumida =>
        $"A música {Nome} pertence a banda {Artista.Nome}"; // Puxando esse Nome do construtor

    public void ExibirFichaTécnica()
    {
        Console.WriteLine(DescricaoResumida);
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}