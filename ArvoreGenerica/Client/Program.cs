using ArvoreGenerica.Model;
using System;
using System.Collections.Generic;

namespace ArvoreGenerica
{
    class Program
    {
        static void Main(string[] args)
        {
            No<string> raiz = new No<string>("A");
            raiz.Adiciona("B");
            raiz.Adiciona("D");
            raiz.Adiciona("C");
            var b = raiz.Pegue("B");
            var c = raiz.Pegue("C");            
            b.Adiciona(new string[] { "E", "F" });
            var f = raiz.Pegue("F");
            b.Adiciona(new string[] { "I", "J", "K" });
            c.Adiciona(new string[] { "G", "H"});
            Console.WriteLine("A altura da raiz é: " + ArvoreG.Altura(raiz));
        }        
    }
}
