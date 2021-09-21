using ArvoreGenerica.Model;
using System;
using System.Collections.Generic;

namespace ArvoreGenerica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Construíndo a árvore
            NoArvore<object> raiz = new NoArvore<object>("A");
            raiz.Adiciona(new string[] { "B", "C", "E" });            

            var B = raiz.Pegue("B");
            var C = raiz.Pegue("C");

            B.Adiciona(new string[] { "D", "F" });            
            C.Adiciona("G");

            //
            ArvoreG.ImprimiDados(raiz);
                      
            Console.ReadKey();
        }             
    }
}
