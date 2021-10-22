from BST import BST

emOrdem = [8, 5, 7, 9, 18, 13, 20]
arvore = BST(valor=10)

for valor in emOrdem:
    arvore.insere(valor)
# percurso = arvore.em_ordem(arvore.raiz)
# for node in percurso:
#     print(node, end=' => ')
arvore.print()
