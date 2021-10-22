from Node import Node

percurso = []


class BST:
    def __init__(self, valor=None, node=None):
        if node:
            self.raiz = node
        elif valor:
            node = Node(valor)
            self.raiz = node
        else:
            self.raiz = None

    @staticmethod
    def eh_raiz(node):
        return node.pai is None

    def insere(self, valor: int, pai=None):
        if pai:
            if valor < pai.valor:
                if not pai.tem_filho_esquerdo():
                    new_node = Node(valor)
                    new_node.pai = pai
                    pai.esquerdo = new_node
                else:
                    print('Já possui filho esquerdo')
            elif valor > pai.valor:
                if not pai.tem_filho_direito():
                    new_node = Node(valor)
                    new_node.pai = pai
                    pai.direito = new_node
                else:
                    print('Já possui filho direito')
        else:
            if not self.raiz.tem_filho_esquerdo():
                if valor < self.raiz.valor:
                    new_node = Node(valor)
                    new_node.pai = self.raiz
                    self.raiz.esquerdo = new_node
                else:
                    print('Já possui filho direito')
            else:
                if not self.raiz.tem_filho_direito():
                    new_node = Node(valor)
                    new_node.pai = self.raiz
                    self.raiz.direito = new_node
                else:
                    print('Já possui filho direito')

    def busca(self, valor):
        aux = self.raiz
        while aux is not None:
            if aux.valor == valor:
                return aux
            if valor < aux.valor:
                aux = aux.esquerdo
            if valor > aux.valor:
                aux = aux.direito
        return None

    def profundidade(self, node):
        if self.eh_raiz(node):
            return 0
        return 1 + self.profundidade(node.pai)

    def nivel(self, node):
        return self.profundidade(node)

    def altura(self, node):
        if node is None:
            return -1
        else:
            return 1 + max(self.altura(node.esquerdo), self.altura(node.direito))

    # Métodos prova

    def pre_ordem(self, node):
        if node is not None:
            percurso.append(node)
            self.pre_ordem(node.esquerdo)
            self.pre_ordem(node.direito)
        return percurso

    def em_ordem(self, node):
        if node is not None:
            self.pre_ordem(node.esquerdo)
            percurso.append(node)
            self.pre_ordem(node.direito)
        return percurso

    def pos_ordem(self, node):
        if node is not None:
            self.pos_ordem(node.esquerdo)
            self.pos_ordem(node.direito)
            percurso.append(node)
        return percurso

    def print(self):
        if self.raiz is None:
            return
        fila = [self.raiz]
        while fila:
            count = len(fila)
            while count > 0:
                temp = fila.pop(0)
                print(temp.valor, end=' ')
                if temp.esquerdo:
                    fila.append(temp.esquerdo)
                if temp.direito:
                    fila.append(temp.direito)
                count -= 1
            print(' ')

    @staticmethod
    def insere_pos_ordem(sequencia: list):
        nova_arvore = BST(node=sequencia[-1])
        sequencia.pop()
        for node in sequencia:
            if BST.eh_raiz(node.pai):
                nova_arvore.insere(node)
            else:
                nova_arvore.insere(node.valor, node.pai)
        return nova_arvore
