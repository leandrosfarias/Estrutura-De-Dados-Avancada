using System;

namespace ArvoreBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ArvoreBinaria arvoreBinaria = new ArvoreBinaria();
            arvoreBinaria.Insere(null, "A", 'E');
            arvoreBinaria.Insere(arvoreBinaria.Raiz, "B", 'E');
            Console.WriteLine(arvoreBinaria.Pega("B").Valor);
        }
    }
}
