using ArvoreBinaria.Entities;
using System;

namespace ArvoreBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ArvoreBuscaBinaria arvore = new ArvoreBuscaBinaria();
            arvore.Insere(50);
            arvore.Insere(40);
            arvore.Insere(60);
            arvore.Insere(30, arvore.GetNode(40));
            arvore.Insere(35, arvore.GetNode(30));
            arvore.Insere(45, arvore.GetNode(40));
            arvore.Insere(55, arvore.GetNode(60));
            arvore.Insere(53, arvore.GetNode(55));
            arvore.Insere(70, arvore.GetNode(60));
            Console.WriteLine(arvore.Nivel(arvore.Raiz));


        }            
    }
} 
