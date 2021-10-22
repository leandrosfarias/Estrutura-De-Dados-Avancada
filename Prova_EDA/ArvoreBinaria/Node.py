class Node:
    def __init__(self, valor):
        self.valor = valor
        self.esquerdo = None
        self.direito = None
        self.pai = None

    def tem_filho_esquerdo(self) -> bool:
        return self.esquerdo is not None

    def tem_filho_direito(self) -> bool:
        return self.direito is not None

    def tem_2_filhos(self) -> bool:
        return self.temFilhoEsquerdo() and self.temFilhoDireito()

    def __str__(self):
        return str(self.valor)
