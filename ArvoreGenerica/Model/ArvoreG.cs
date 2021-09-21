using System;
using System.Collections.Generic;
using System.Text;

namespace ArvoreGenerica.Model
{
    public class ArvoreG
    {     
        public static List<object> Percurso = new List<object>();

        // Profundidade do nó
        public static int Profundidade(NoArvore<object> no)
        {
            if (no.EhRaiz())
                return 0;
            return 1 + Profundidade(no.Pai);
        }

        // Nivel do nó
        public static int Nivel(NoArvore<object> no)
        {
            return ArvoreG.Profundidade(no);
        }

        // Altura do nó
        public static int Altura(NoArvore<object> no)
        {
            int altura = -1;

            foreach (NoArvore<object> filho in no.Filhos)
            {
                int fl = Altura(filho);
                altura = Math.Max(fl, altura);
            }
            altura += 1;
            return altura;
        }

        // Percurso em pré-ordem
        public static List<object> PreOrdem(NoArvore<object> raiz)
        {
            if (raiz == null)
                return Percurso;
            PreOrdemAuxiliar(raiz);
            return Percurso;
        }

        // Aux
        private static void PreOrdemAuxiliar(NoArvore<object> no)
        {
            if (no.Filhos == null)
                return;
            Percurso.Add(no);
            foreach (NoArvore<object> filho in no.Filhos)
            {
                PreOrdemAuxiliar(filho);
            }            
        }
        
        // Informações
        public static void ImprimiDados(NoArvore<object> raiz)
        {
            var percurso = ArvoreG.PreOrdem(raiz);
            foreach (NoArvore<object> no in percurso)
            {
                if (no.EhRaiz())
                {                  
                    Console.WriteLine($" Raiz: {no} ");
                    break;
                }
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Os nós: [Pré ordem]");
            foreach (NoArvore<object> no in percurso)
            {
                Console.Write(" ");
                Console.Write($"{no}, ");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.Write("Nós folhas: ");
            foreach (NoArvore<object> no in percurso)
            {
                if (no.EhNoExterno())
                {
                    Console.Write($"{no}, ");
                }
            }

            // 
            Console.WriteLine("");
            Console.WriteLine("O grau de cada nó:-->");
            foreach (NoArvore<object> no in percurso)
            {
                Console.WriteLine($" {no} - {no.Grau}");
            }

            Console.WriteLine("A profundidade de cada nó: ");
            foreach (NoArvore<object> no in percurso)
            {
                Console.WriteLine($" {no} - {ArvoreG.Profundidade(no)}");
            }

            Console.WriteLine("A altura de cada nó: ");
            foreach (NoArvore<object> no in percurso)
            {
                Console.WriteLine($" {no} - {ArvoreG.Altura(no)}");
            }

            Console.WriteLine("Os níveis de cada nó: ");
            foreach (NoArvore<object> no in percurso)
            {
                Console.WriteLine($" {no} - {ArvoreG.Nivel(no)}");
            }
        }
    }
}
