using ArvoreBinaria.Entities;
using System;
using System.Collections.Generic;

namespace ArvoreBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ArvoreBuscaBinaria arvore = new ArvoreBuscaBinaria();
            arvore.Insere(5);
            arvore.Insere(1);
            arvore.Insere(8);
            arvore.Insere(9, arvore.GetNode(8));
            //Program.PrintPercurso(arvore.PosOrdem(arvore.Raiz));
            PrintPercurso(arvore.PosOrdem());
            Console.ReadKey();
        }

        public static void PrintPercurso(List<Node> percurso)
        {
            foreach (Node node in percurso)
            {
                Console.Write(node + "-> ");
            }
        }

    }
} 
