from modelos.avaliacao import Avaliacao
class Livro:
    estante = []

    def __init__(self,nome,autor):
        self._nome = nome
        self._autor = autor
        self._status = True
        self._avaliacao = []
        Livro.estante.append(self)


    @classmethod
    def listar_livros(cls):
        print('Livros da estante\n')
        if(len(Livro.estante) == 0):
            print('A estante esta sem livros no momento.')

        print(f'NOME'.ljust(30) +'|' + 'AUTOR'.ljust(29)+'|'+'STATUS')
        for livros in Livro.estante:
            print(f'livro: {livros._nome.ljust(22)} | autor:{livros._autor.ljust(22)}|{livros.status_livro.ljust(22)}'
                  f'| avaliacao {livros.media_avaliacao}')

    @property
    def status_livro(self):
        return f'livro novo' if self._status else 'livro antigo'

    def alterar_status_livro(self):
         self._status = not self._status


    def __str__(self):
        return f'{self._nome} - {self._autor} | {self.status_livro}'

    def avaliar(self,cliente,nota):
        avaliar = Avaliacao(cliente,nota)
        self._avaliacao.append(avaliar)

    @property
    def media_avaliacao(self):
        if not self._avaliacao:
            return 0
        soma_de_notas = sum(avaliacao._nota for avaliacao in self._avaliacao)
        quantidade_de_notas = len(self._avaliacao)
        media= round(soma_de_notas / quantidade_de_notas,2)
        return media




