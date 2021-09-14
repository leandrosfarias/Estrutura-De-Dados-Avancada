using System;
using System.Collections.Generic;

namespace ArvoreGenerica.Model
{
    public class No<T> 
    {
        public LinkedListNode<T> Dado { get; set; }
        public No<T> Pai { get; set; }
        public LinkedList<No<T>> filhos = new LinkedList<No<T>>();
        public int Grau { get; set; }

        public No(T valor)
        {
            LinkedListNode<T> dado = new LinkedListNode<T>(valor);
            this.Dado = dado;
        }

        public No(LinkedListNode<T> dado, No<T> pai)
        {
            this.Dado = dado;
            this.Pai = pai;
        }
       
        public void Adiciona(T filho)
        {
            No<T> dado = new No<T>(filho);
            filhos.AddLast(dado);
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

        public No<T> Pegue(object valor)
        {
            foreach (No<T> filho in filhos)
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
            if (this.filhos.Count == 0)
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
