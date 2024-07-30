from modelos.livros import Livro


l1 = Livro('pequeno principe','miguel')
l1.avaliar('humberto',9)
l1.avaliar('miguel',7)

l2 = Livro('harry potter','humberto')
l2.alterar_status_livro()

def main():
    Livro.listar_livros()

if(__name__ == '__main__'):
    main()