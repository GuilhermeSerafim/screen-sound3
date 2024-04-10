namespace ScreenSound.Desafios.PetShop;

internal class Pet(string nome, int idade, string raca, char sexo)
{
    public string Nome { get; set; } = nome;
    public int Idade { get; set; } = idade;
    public string Raca { get; set; } = raca;
    public char Sexo { get; set; } = sexo;
}
