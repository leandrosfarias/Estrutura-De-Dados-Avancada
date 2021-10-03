using ArvoreBinaria.Entities;
using System;
using System.Text;

namespace ArvoreBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ArvoreB arvore = new ArvoreB("A");
            arvore.Insere("B", null, 'E');
            Console.WriteLine(arvore.Raiz);
           
        }
    }
}
