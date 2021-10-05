using ArvoreBinaria.Entities;
using System;

namespace ArvoreBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ArvoreBuscaBinaria arvore = new ArvoreBuscaBinaria();
            arvore.Insere(40);
            arvore.Insere(30);
            arvore.Insere(65);
            arvore.Insere(75, arvore.GetNode(65));
            arvore.Insere(25, arvore.GetNode(30));
            arvore.Insere(35, arvore.GetNode(30));
            arvore.Insere(38, arvore.GetNode(35));
            arvore.Insere(28, arvore.GetNode(25));
            arvore.Insere(26, arvore.GetNode(28));


            arvore.PrintNodes(arvore.Raiz);
            arvore.PrintGraus(arvore.Raiz);
            arvore.PrintProfundidades(arvore.Raiz);
            arvore.PrintNivel(arvore.Raiz);

            Console.WriteLine("Pré Ordem:\n");
            arvore.PreOrdem();
            Console.WriteLine("\nEm ordem:\n");
            arvore.EmOrdem();
            Console.WriteLine("\nPós ordem:\n");
            arvore.PosOrdem();
            Console.ReadKey();
        }
    }
} 
