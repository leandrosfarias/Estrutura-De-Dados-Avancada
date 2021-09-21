using System;
using System.Collections.Generic;

namespace ArvoreGenerica.Model
{
    public class NoArvore<T> 
    {
        public LinkedListNode<T> Dado { get; set; }
        public NoArvore<T> Pai { get; set; }
        public LinkedList<NoArvore<T>> Filhos = new LinkedList<NoArvore<T>>();
        public int Grau { get; set; }

        public NoArvore(T valor)
        {
            LinkedListNode<T> dado = new LinkedListNode<T>(valor);
            this.Dado = dado;
        }

        public NoArvore(LinkedListNode<T> dado, NoArvore<T> pai)
        {
            this.Dado = dado;
            this.Pai = pai;
        }
       
        public void Adiciona(T filho)
        {
            NoArvore<T> dado = new NoArvore<T>(filho);
            Filhos.AddLast(dado);
            dado.Pai = this;
            this.Grau++;
        }

        public void Adiciona(T[] filhos)
        {
            for (int i = 0; i < filhos.Length; i++)
            {
                this.Adiciona(filhos[i]);
            }
        }

        public NoArvore<T> Pegue(object valor)
        {
            foreach (NoArvore<T> filho in Filhos)
            {
                if (filho.Dado.Value.Equals(valor))
                    return filho;
            }
            return null;
        }               

        public bool EhRaiz()
        {
            if (this.Pai == null)
                return true;
            else
                return false;
        }

        public bool EhNoExterno()
        {
            if (this.Filhos.Count == 0)
                return true;
            else
                return false;
        }    
        
        public object Valor()
        {
            return this.Dado.Value;
        }
        
        public override string ToString()
        {
            return this.Dado.Value.ToString();
        }
    }
}
