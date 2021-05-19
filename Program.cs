using System;

namespace sorteio
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numeros = { rnd.Next(1, 49), rnd.Next(1, 49), rnd.Next(1, 49), rnd.Next(1, 49), rnd.Next(1, 49), rnd.Next(1, 49) };

            Array.Sort(numeros);
            Console.WriteLine("Números sorteados: ");
            foreach (int i in numeros) Console.Write(i + " ");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Insere o teu palpite de 6 números: ");
            int[] palpites = { int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()) };

            int combinacao = 0;
            if (palpites[0] == numeros[0] || palpites[0] == numeros[1] || palpites[0] == numeros[2] || palpites[0]== numeros[0] || palpites[0] == numeros[4] || palpites[0] == numeros[5])
            {
                combinacao = combinacao + 1;
            }
            if(palpites[1] == numeros[0] || palpites[1] == numeros[1] || palpites[1] == numeros[2] || palpites[1] == numeros[3] || palpites[1] == numeros[4] || palpites[1] == numeros[5])
            {
                combinacao = combinacao + 1;
            }
            if (palpites[2] == numeros[0] || palpites[2] == numeros[1] || palpites[2] == numeros[2] || palpites[2] == numeros[3] || palpites[2] == numeros[4] || palpites[2] == numeros[5])
            {
                combinacao = combinacao + 1;
            }
            if (palpites[3] == numeros[0] || palpites[3] == numeros[1] || palpites[3] == numeros[2] || palpites[3] == numeros[3] || palpites[3] == numeros[4] || palpites[3] == numeros[5])
            {
                combinacao = combinacao + 1;
            }
            if (palpites[4] == numeros[0] || palpites[4] == numeros[1] || palpites[4] == numeros[2] || palpites[4] == numeros[3] || palpites[4] == numeros[4] || palpites[4] == numeros[5])
            {
                combinacao = combinacao + 1;
            }
            if (palpites[5] == numeros[0] || palpites[5] == numeros[1] || palpites[5] == numeros[2] || palpites[5] == numeros[3] || palpites[5] == numeros[4] || palpites[5] == numeros[5])
            {
                combinacao = combinacao + 1;
            }

            if(combinacao == 0)
            {
                Console.Write("Não acertou nenhum número.");
            }
            else if(combinacao == 1)
            {
                Console.Write("Acertou um número.");
            }
            else
            {
                Console.Write("Acertou " + combinacao + " números.");
            }
            
        }
    }
}
