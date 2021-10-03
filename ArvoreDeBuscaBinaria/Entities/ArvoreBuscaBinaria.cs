using System;

namespace ArvoreBinaria.Entities
{
    public class ArvoreBuscaBinaria
    {
        public Node Raiz { get; set; }

        public bool Vazio()
        {
            return this.Raiz == null;
        }

        public bool EhRaiz(Node no)
        {
            return this.Raiz.Equals(no);
        }        

        public void Insere(int dado)
        {
            if (Vazio())
                this.Raiz = new Node(dado);
            else
            {
                Node aux = this.Raiz;

                while (aux != null)
                {
                    if (dado < aux.Dado)
                    {
                        if (aux.Esquerdo == null)
                        {
                            Node novoNo = new Node(dado);
                            aux.Esquerdo = novoNo;
                            novoNo.Pai = aux;
                            return;
                        }
                        aux = aux.Esquerdo;
                    }
                    else
                    {
                        if (aux.Direito == null)
                        {
                            Node novoNo = new Node(dado);
                            aux.Direito = novoNo;
                            novoNo.Pai = aux;
                            return;
                        }
                        aux = aux.Direito;
                    }
                }
            }
        }

        public void Insere(int dado, Node pai)
        {
            if (Vazio())
                this.Raiz = new Node(dado);
            else
            {
                if (pai != null)
                {
                    Node aux = pai;
                    while (aux != null)
                    {
                        if (dado < aux.Dado)
                        {
                            if (aux.Esquerdo == null)
                            {
                                Node novoNo = new Node(dado);
                                aux.Esquerdo = novoNo;
                                novoNo.Pai = aux;
                                return;
                            }
                            aux = aux.Esquerdo;
                        }
                        else
                        {
                            if (aux.Direito == null)
                            {
                                Node novoNo = new Node(dado);
                                aux.Direito = novoNo;
                                novoNo.Pai = aux;
                                return;
                            }
                            aux = aux.Direito;
                        }
                    }
                }
            }
        }

        public Node GetNode(int elemento)
        {
            Node aux = this.Raiz;
            while (aux != null)
            {
                if (aux.Dado == elemento) return aux;
                if (elemento < aux.Dado) aux = aux.Esquerdo;
                if (elemento > aux.Dado) aux = aux.Direito;
            }
            return null;
        }

        public Node Min()
        {
            if (Vazio()) return null;
            return Min(this.Raiz);
        }

        private Node Min(Node no)
        {
            if (no.Esquerdo == null) return no;
            else return Min(no.Esquerdo);
        }

        public Node Max()
        {
            if (Vazio()) return null;

            Node node = this.Raiz;
            while (node.Direito != null)
                node = node.Direito;
            return node;
        }

        public int Altura()
        {
            return Altura(this.Raiz);
        }

        public int Altura(Node no)
        {
            if (no == null) return -1;
            else return 1 + Math.Max(Altura(no.Esquerdo), Altura(no.Direito));
        }

        public  int Profundidade(Node no)
        {
            if (this.EhRaiz(no))
                return 0;
            return 1 + Profundidade(no.Pai);            
        }

        public int Nivel(Node no)
        {
            return this.Profundidade(no);
        }

        public void PreOrdem()
        {
            PreOrdem(this.Raiz);
        }

        private void PreOrdem(Node no)
        {
            if (no != null)
            {
                Console.WriteLine(no.Dado);
                PreOrdem(no.Esquerdo);
                PreOrdem(no.Direito);
            }
        }              
    }    
}
