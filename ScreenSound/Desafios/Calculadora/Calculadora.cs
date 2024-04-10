namespace ScreenSound.Desafios.Calculadora
{
    internal class Calculadora
    {

        public void Soma(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Subtracao(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public void Multiplicacao(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public void Divisao(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        public void Potencia(int a, int b)
        {
            Console.WriteLine(a ^ b);
        }
        public void RaizQuadrada(int a)
        {
            Console.WriteLine(Math.Sqrt(a));
        }
    }
}
