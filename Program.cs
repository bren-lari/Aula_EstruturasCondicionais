using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();

            string situacao = "";

            Console.WriteLine("--- Processo seletivo escolar ---\r\n");

            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            double media = nota1 + nota2 /2;

            Console.WriteLine("Média final:", media);
            
            Console.WriteLine(media);

            if(media >= 7){
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("O aluno foi aprovado!");
            }else {
                Console.ForegroundColor = ConsoleColor.Red;
                situacao = "O aluno foi reprovado!";
                }

            Console.WriteLine(situacao);
            }

            }
            }