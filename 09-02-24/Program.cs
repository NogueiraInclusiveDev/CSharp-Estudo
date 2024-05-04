using System;

namespace _09_02_24
{
    class Program
    {
        static void Main(string[] args)
        {
            bool afirmacao;
            bool afirmacao1;
            bool afirmacao2;
            bool afirmacao3;
            /*
             > representa maior que 
             < representa menor que
             <= representa menor que ou igual a
             >= representa maior que ou igual a
             == representa igualdade
             != representa diferença entre
            */

            afirmacao = 1 > 2;
            Console.WriteLine(afirmacao);

            int n1 = 10;
            int n2 = 5;
            afirmacao = n2 < n1;
            Console.WriteLine(afirmacao);
            //tentativa de exercicio
            Double alturaRomulo = 1.87;
            Double alturaKeity = 1.53;
            afirmacao = alturaKeity < alturaRomulo;
            Console.WriteLine(afirmacao);
            Console.WriteLine($"O valor {n2} é menor que {n1}?\nR:{afirmacao}");
            afirmacao1 = n2 <= 10;
            afirmacao2 = n1 >= 10;
            afirmacao3 = n1 == 10;
            String nome = "Dona Rosa";
            afirmacao = nome == "Dona Rosa";
            String letra = "A";
            afirmacao = letra == "a";
            afirmacao = letra != "a";

            /*
            Operador AND &&
            A   B     Resultado

            F   F         F 
            F   V         F
            V   F         F
            V   V         V
       =====================================
            Operador  OR ||
            A   B     Resultado
   
            F   F         F
            F   V         V
            V   F         V
            V   V         V
            */
            bool a, b, resultado;
            a = true;
            b = false;
            resultado = a && b;
            Console.WriteLine("O resultado de a AND b = " + resultado);
            resultado = a || b;
            Console.WriteLine("O resultado de a OR b = " + resultado);

            int idade = 10;
            if(idade < 18)
            {
                Console.WriteLine("Vai trocar as fraldas");


                // Exercicio solicitado pelo professor Thiago 

                Console.Write("Digite sua idade: ");
                string input = Console.ReadLine();

                int idades;
                bool parseSucesso = Int32.TryParse(input, out idades);

                if (parseSucesso && idades > 0 && idades < 120)
                {
                    Console.WriteLine("Cadastro bem-sucedido!");
                }
                else
                {
                    Console.WriteLine("Cadastro falhou. Idade inválida.");
                }
            }
        }
    }
}
