using System;
using System.Collections.Generic;
using System.Text;

namespace ArvoreBinaria
{
    class Node
    {
        public String Dado { get; set; }
        public Node Esquerdo { get; set; }
        public Node Direito { get; set; }
        public Node Pai { get; set; }
        
        public Node(String dado, Node pai)
        {
            this.Pai = pai;
            this.Dado = dado;
            this.Esquerdo = this.Direito = null;
        }

        public Node(String dado) : this(dado, null)
        {
            Dado = dado;
        }

        public bool TemEsquerdo()
        {
            if (Esquerdo == null)
                return false;
            return true;
        }

        public bool TemDireito()
        {
            if (Direito == null)
                return false;
            return true;
        }

        public override String ToString()
        {
            return Dado.ToString();
        }
    }
}
