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
        public int Grau { get; set; }
        public char TipoFilho { get; internal set; }

        public Node(int valor)
        {
            this.Dado = valor;            
        }

        public bool TemEsquerdo()
        {
            return this.Esquerdo != null;
        }

        public bool TemDireito()
        {
            return this.Direito != null;
        }

        public override string ToString()
        {
            return Dado.ToString();
        }
    }
}
