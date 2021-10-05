using System;
using System.Collections.Generic;

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
                            aux.Grau++;
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
                            aux.Grau++;
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
                                aux.Grau++;
                                novoNo.Pai = aux;
                                novoNo.TipoFilho = 'E';
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
                                aux.Grau++;
                                novoNo.Pai = aux;
                                novoNo.TipoFilho = 'D';
                                return;
                            }
                            aux = aux.Direito;
                        }
                    }
                }
            }
        }
         
        public void Remove(int valor)
        {
            // Nó a ser removido
            Node node = GetNode(valor);
            // Caso o nó seja uma folha
            if (EhFolha(node))
            {
                Node aux = node.Pai;
                if (TipoFilho(node) == 'E')
                {
                    aux.Esquerdo = null;
                    node.Pai = null;
                }
                else if (TipoFilho(node) == 'D')
                {
                    aux.Direito = null;
                    node.Pai = null;
                }
            }
            // O nó a ser removido tem os dois filhos (esquerdo e direito)
            else if (node.TemEsquerdo() && node.TemDireito())
            {
                throw new NotImplementedException();
            }
            // O nó a ser removido tem somente um filho (esquerdo ou direito)
            else if (node.TemEsquerdo() || node.TemDireito())
            {
                if (node.TemEsquerdo())
                {
                    if (TipoFilho(node) == 'E')
                        node.Pai.Esquerdo = node.Esquerdo;
                    else if (TipoFilho(node) == 'D')
                        node.Pai.Direito = node.Esquerdo;
                }
                else if (node.TemDireito())
                {
                    if (TipoFilho(node) == 'E')
                        node.Pai.Esquerdo = node.Direito;
                    else if (TipoFilho(node) == 'D')
                        node.Pai.Direito = node.Direito;
                }                                    
            }            
        }

        public Node GetNode(int valor)
        {
            Node aux = this.Raiz;
            while (aux != null)
            {
                if (aux.Dado == valor) return aux;
                if (valor < aux.Dado) aux = aux.Esquerdo;
                if (valor > aux.Dado) aux = aux.Direito;
            }
            return null;
        }

        public Node Min()
        {
            if (Vazio()) return null;
            return Min(this.Raiz);
        }

        public Node Min(Node node)
        {
            if (node.Esquerdo == null) return node;
            else return Min(node.Esquerdo);
        }

        public Node Max()
        {
            if (Vazio()) return null;
            return Max(this.Raiz);
        }

        public Node Max(Node node)
        {
            if (node.Direito == null) return node;
            else return Max(node.Direito);
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

        public int Grau(Node node)
        {
            return node.Grau;
        }

        public void PreOrdem()
        {
            PreOrdem(this.Raiz);
        }

        public void PreOrdem(Node node)
        {
            if (node != null)
            {   
                Console.Write(node.Dado + " -> ");
                PreOrdem(node.Esquerdo);
                PreOrdem(node.Direito);
            }
        }

        public void EmOrdem()
        {
            this.EmOrdem(this.Raiz);
        }

        public void EmOrdem(Node node)
        {
            if (node != null)
            {
                PreOrdem(node.Esquerdo);
                Console.Write(node.Dado + " -> ");
                PreOrdem(node.Direito);
            }
        }

        public void PosOrdem()
        {
            this.PosOrdem(this.Raiz);
        }

        public void PosOrdem(Node node)
        {
            if (node != null)
            {
                PosOrdem(node.Esquerdo);
                PosOrdem(node.Direito);
                Console.Write(node.Dado + " -> ");
            }
        }
        
        public bool EhFolha(Node node)
        {
            if (node.Esquerdo == null && node.Direito == null)
                return true;
            return false;
        }

        public char TipoFilho(Node node)
        {
            return node.TipoFilho;
        }

        

        public void PrintNodes(Node raiz)
        {
            Console.WriteLine("Os nós...");
            Queue<Node> filaNodes = new Queue<Node>();
            filaNodes.Enqueue(raiz);
            while (filaNodes.Count > 0)
            {
                Node node = filaNodes.Dequeue();
                Console.WriteLine(node.Dado);
                if (node.Esquerdo != null)
                {
                    filaNodes.Enqueue(node.Esquerdo);
                }
                if (node.Direito != null)
                {
                    filaNodes.Enqueue(node.Direito);
                }
            }
        }

        public void PrintGraus(Node raiz)
        {
            Console.WriteLine("O grau de cada nó...");
            Queue<Node> filaNodes = new Queue<Node>();
            filaNodes.Enqueue(raiz);
            while (filaNodes.Count > 0)
            {
                Node node = filaNodes.Dequeue();
                Console.WriteLine(node.Grau);
                if (node.Esquerdo != null)
                {
                    filaNodes.Enqueue(node.Esquerdo);
                }
                if (node.Direito != null)
                {
                    filaNodes.Enqueue(node.Direito);
                }
            }
        }

        public void PrintAlturas(Node raiz)
        {
            Console.WriteLine("Altura de cada nó...");
            Queue<Node> filaNodes = new Queue<Node>();
            filaNodes.Enqueue(raiz);
            while (filaNodes.Count > 0)
            {
                Node node = filaNodes.Dequeue();
                Console.WriteLine(Altura(node));
                if (node.Esquerdo != null)
                {
                    filaNodes.Enqueue(node.Esquerdo);
                }
                if (node.Direito != null)
                {
                    filaNodes.Enqueue(node.Direito);
                }
            }
        }

        public void PrintProfundidades(Node raiz)
        {
            Console.WriteLine("Profundidade de cada nó...");
            Queue<Node> filaNodes = new Queue<Node>();
            filaNodes.Enqueue(raiz);
            while (filaNodes.Count > 0)
            {
                Node node = filaNodes.Dequeue();
                Console.WriteLine(Profundidade(node));
                if (node.Esquerdo != null)
                {
                    filaNodes.Enqueue(node.Esquerdo);
                }
                if (node.Direito != null)
                {
                    filaNodes.Enqueue(node.Direito);
                }
            }
        }

        public void PrintNivel(Node raiz)
        {
            Console.WriteLine("Nível de cada nó...");
            Queue<Node> filaNodes = new Queue<Node>();
            filaNodes.Enqueue(raiz);
            while (filaNodes.Count > 0)
            {
                Node node = filaNodes.Dequeue();
                Console.WriteLine(Nivel(node));
                if (node.Esquerdo != null)
                {
                    filaNodes.Enqueue(node.Esquerdo);
                }
                if (node.Direito != null)
                {
                    filaNodes.Enqueue(node.Direito);
                }
            }
        }

        public void PrintArvore(int valor)
        {
            throw new NotImplementedException();
        }

    }    
}
