using System;
using System.Text;

namespace ArvoreBinaria.Entities
{
    class ArvoreB
    {
        public Node Raiz { get; set; }

        public ArvoreB(string valorRaiz)
        {
            Node aux = new Node(valorRaiz);
            this.Raiz = aux;
        }

        public bool Insere(string dado, Node pai, char tipoFilho)
        {
            Node aux;
            bool ok = false;
            if (pai == null)
            {
                aux = new Node(dado);
                Raiz = aux;
                ok = true;
            }
            else
            {
                if ((tipoFilho == 'E') && (pai.TemEsquerdo()))
                {
                    Console.WriteLine("*** ERRO: Já possui filho esquerdo! ***");
                    ok = false;
                }
                if ((tipoFilho == 'D') && (pai.TemDireito()))
                {
                    Console.WriteLine("*** ERRO: Já possui filho direito! ***");
                    ok = false;
                    return false;
                }
                aux = new Node(dado, pai);
                if (tipoFilho == 'E')
                    pai.Esquerdo = aux;
                else
                    pai.Direito = aux;
                ok = true;
            }
            return ok;
        }

        public void ImprimiPreOrdem(Node node)
        {
            if (node == null)
                return;
            Console.Write(node.Dado + " ");
            this.ImprimiPreOrdem(node.Esquerdo);
            this.ImprimiPreOrdem(node.Direito);
        }

        public void ImprimiPreOrdem()
        {
            this.ImprimiPreOrdem(this.Raiz);
        }
        
        public Node Busca(Node inicio, String procurado)
        {
            if (inicio != null)
            {
                if (Object.Equals(procurado, inicio.Dado))
                {
                    return inicio;
                } 
                else
                {
                    Busca(inicio.Esquerdo, procurado);
                    Busca(inicio.Direito, procurado);
                }
            }
            return null;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(this.Raiz);
            return base.ToString();
        }
    }
}
