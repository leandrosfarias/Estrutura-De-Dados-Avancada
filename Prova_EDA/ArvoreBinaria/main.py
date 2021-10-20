from BST import BST

arvore = BST(5)
arvore.insere(1)
arvore.insere(8)
raiz = arvore.busca(5)
arvore.insere(9, arvore.busca(8))
# node = arvore.busca(9)
percurso = arvore.pos_ordem(raiz)
arvore.insere_pos_ordem(percurso)
# for node in percurso:
#     print(node, end=" => ")
arvore.print_arvore(raiz)
