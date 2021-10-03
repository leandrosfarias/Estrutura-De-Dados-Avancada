using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ArvoreBinaria.Entities
{
    public class Node
    {
        public int Dado { get; set; }
        public Node Esquerdo { get; set; }
        public Node Direito { get; set; }
        public Node Pai { get; set; }

        public Node(int valor)
        {
            this.Dado = valor;
            this.Esquerdo = null;
            this.Direito = null;
        }

        public override string ToString()
        {
            return Dado.ToString();
        }
    }
}
