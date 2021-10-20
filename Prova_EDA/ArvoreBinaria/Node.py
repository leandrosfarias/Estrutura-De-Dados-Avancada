class Node:
    def __init__(self, valor):
        self.valor = valor
        self.esquerdo = None
        self.direito = None
        self.pai = None

    def temFilhoEsquerdo(self):
        return self.esquerdo is not None

    def temFilhoDireito(self):
        return self.direito is not None

    def __str__(self):
        return str(self.valor)
