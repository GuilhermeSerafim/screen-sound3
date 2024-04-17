/*private */List<int> listaDeNumeros = new()
{
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
};

// Polimorfismo
// Ao colocar a Lista em um IEnumerable, você passa a ter metodos em relação a leitura e perde add, exclusão
IEnumerable<int> numeros = listaDeNumeros;
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}
