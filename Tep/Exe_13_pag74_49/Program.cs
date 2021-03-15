using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_13_pag74_49
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] candidatos = new string[10] { "Russo", "Jose", "Cleiton", "Farlen", "Cleber", "Irineu", "Jucimar", "Pedro", "Joseilda", "Joyline" };
            int indice = 0, voto_eleitor = 0, maior = int.MinValue, posicao = 0;
            int[] votos = new int[10];
            Random aleatorio = new Random();
            Console.WriteLine("...................Escolha um candidato.................");

            for (indice = 0; indice < 10; indice++)
            {
                Console.WriteLine(indice + " - " + candidatos[indice]);
            }

            Console.WriteLine("...................Votação.................");
            for (voto_eleitor = 0; voto_eleitor <= 36000; voto_eleitor++)
            {
                votos[aleatorio.Next(10)]++;
            }
            Console.WriteLine("...................Resultados.................");

            for (indice = 0; indice < 10; indice++)
            {
                Console.WriteLine(indice + " - " + candidatos[indice] + " obteve: " + votos[indice] + " votos ");

                if (votos[indice] > maior)
                {
                    maior = votos[indice];
                    posicao = indice;
                }
            }
            Console.WriteLine("...................Vencedor.................");
            Console.WriteLine("O Vencedor das eleições é : " + candidatos[posicao]);
            Console.ReadKey();
        }


    }
    }

