using System;

namespace Media4Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 , n2 , n3 , n4 , media ; // n= nota do aluno
           
            Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" ----- MÉDIA DO ALUNO (COM 4 NOTAS)----- \n");
                            
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Digite as suas notas abaixo.");

                    Console.Write("Nota 1: ");
                            n1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Nota 2: ");
                            n2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Nota 3: ");
                            n3 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Nota 4: ");
                            n4 = Convert.ToDouble(Console.ReadLine());

            media = (n1 + n2 + n3 + n4) / 4;
            
            if (media > 5 )
            Console.WriteLine($"Você ficou com média {media}. Resultado: Aprovado.");

            else if (media >=5 && media <=6)
            Console.WriteLine($"Você ficou com média {media}. Resultado: Recuperação.");

            else if (media <= 5)
            Console.WriteLine($"Você ficou com média {media}. Resultado: Reprovado.");
            
            Console.WriteLine ("Pressione enter para finalizar.");
            Console.ReadKey();
        }
    }
}
