﻿namespace ScreenSound.Modelos;

// Apenas o projeto terá acesso - Internal
// Quando queremos que outros projetos vejam, deixamos como public
internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        if (nota > 0 || nota < 10)
        {
            Nota = nota;
        }
        else
        {
            Console.WriteLine("Nota deve ser maior que 0 e menor que 10");
        }
    }

    public int Nota { get; } // Acesso apenas para leitura (pois o construtor já seta o valor)

    public static Avaliacao TextoParaAvaliacao(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
    // Utilização Comum: Métodos estáticos são comumente
    // usados para implementar funcionalidades que são independentes
    // do estado de um objeto específico. Por exemplo, métodos utilitários,
    // métodos de fábrica, métodos de conversão e métodos de inicialização estática são frequentemente definidos como estáticos.
}
