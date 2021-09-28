using System;
using System.Collections.Generic;
using System.Text;

namespace ArvoreBinaria
{
    class Node
    {
        public string Valor { get; set; }
        public Node Esquerdo { get; set; }
        public Node Direito { get; set; }
        public Node Pai { get; set; }

        // Construtor principal, recebe o conteúdo e o pai do nó
        public Node(string valor, Node pai)
        {
            this.Valor = valor;
            this.Pai = pai;
            this.Direito = Esquerdo = null;
        }

        // Construtor para raiz
        public Node(string valor) : this(valor, null) { }
         
        public Boolean TemFilhoEsquerdo()
        {
            if (Esquerdo == null)
                return false;            
            return true;
        }

        public Boolean TemFilhoDireito()
        {
            if (Direito == null)
                return false;
            return true;
        }
     
        public override string ToString()
        {
            return this.Valor.ToString();
        }
    }
}
