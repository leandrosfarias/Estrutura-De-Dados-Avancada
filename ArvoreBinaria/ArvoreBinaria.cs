using System;
using System.Collections.Generic;
using System.Text;

namespace ArvoreBinaria
{
    class ArvoreBinaria
    {
        public Node Raiz { get; set; }

        public ArvoreBinaria() { }
        
        public bool Insere(Node pai, String valor, char tipoFilho)
        {
            Node aux;
            Boolean ok = false;
            if (pai == null)
            {
                aux = new Node(valor);
                this.Raiz = aux;
                ok = true;
            }
            else
            {
                if ((tipoFilho == 'E') && (pai.TemFilhoEsquerdo()))
                {
                    Console.WriteLine("*** ERRO: já possui filho esquerdo! ***");
                    ok = false;
                }
                else if ((tipoFilho == 'D') && (pai.TemFilhoDireito())) 
                    {
                    Console.WriteLine("*** ERRO: já possui filho direito! ***");
                    ok = false;
                    return false;
                    }
                aux = new Node(valor, pai);
                if (tipoFilho == 'E')
                    pai.Esquerdo = aux;
                else
                    pai.Direito = aux;
                ok = true;
            }
            return ok;
        }

        public Node Pega(string valor, Node inicio)
        {
            if (inicio != null)
            {
                if (valor == inicio.Valor)
                    return inicio;
                Pega(valor, inicio.Esquerdo);
                Pega(valor, inicio.Direito);
            }
            return null;
        } 

        public Node Pega(string valor)
        {
            if (this.Raiz != null)
            {
                var aux = this.Raiz;
                if (this.Raiz.Valor == valor)
                    return this.Raiz;
                Pega(aux.Esquerdo.Valor);
                Pega(aux.Direito.Valor);
            }
            return null;
        }

        public bool Pesquisa(Node inicio, String procurado)
        {
            if (inicio != null)
            {
                if (procurado.Equals(inicio.Valor))
                    return true;
                Pesquisa(inicio.Esquerdo, procurado);
                Pesquisa(inicio.Direito, procurado);
            }
            return false;
        }
    }
}
