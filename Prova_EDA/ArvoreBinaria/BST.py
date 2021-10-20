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

    def eh_raiz(self, node):
        return self.raiz == node

    def insere(self, valor=None, pai=None):
        if pai:
            if valor < pai.valor:
                new_node = Node(valor)
                new_node.pai = pai
                pai.esquerdo = new_node
            else:
                new_node = Node(valor)
                new_node.pai = pai
                pai.direito = new_node
        else:
            if valor < self.raiz.valor:
                new_node = Node(valor)
                new_node.pai = self.raiz
                self.raiz.esquerdo = new_node
            else:
                new_node = Node(valor)
                new_node.pai = self.raiz
                self.raiz.direito = new_node

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

    def print_arvore(self, node):
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

    def insere_pos_ordem(self, sequencia):
        pass
