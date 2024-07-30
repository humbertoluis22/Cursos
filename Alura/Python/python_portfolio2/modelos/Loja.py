from modelos.avaliacao import Avalicao
class Loja:
    lojas = []
    def __init__(self,nome,localidade):
        self._nome = nome
        self._localidade= localidade
        self._status = False
        self._mostruario = []
        self._avaliacao = []
        Loja.lojas.append(self)


    def __str__(self):
        return f'nome: {self._nome} | Localidade: {self._localidade} | aberta : {self._status} '

    def avaliar_loja(self,nome,nota):
        avaliacao = Avalicao(nome,nota)
        self._avaliacao.append(avaliacao)
        print(f'Avaliação da loja {self._nome}')
    @property
    def mostrar_media_avaliacao(self):
        if not self._avaliacao:
            return 0
        soma_avaliacao = sum(avaliacao._nota for avaliacao in self._avaliacao)
        quantidade_de_avalicao = len(self._avaliacao)
        media_avaliacao = round(soma_avaliacao/quantidade_de_avalicao,1)
        return media_avaliacao
    @classmethod
    def listar_lojas(cls):
        print('Nome'.ljust(23) + '|'+'Localidade'.ljust(30) + '|' + 'Status'.ljust(21) + '|' + 'Avaliação')
        for loja in cls.lojas:
            print(f'Nome:{loja._nome}  | Localidade:{loja._localidade}   |Status:{loja.exibi_status_loja}  |Avaliação:{loja.mostrar_media_avaliacao}')

    def altera_status_loja(self):
        self._status = not self._status
    @property
    def exibi_status_loja(self):
        return  f'Loja Aberta' if self._status  else 'Loja Fechada'




lj1 = Loja('Loja Do humberto','Franco da rocha')
lj1.avaliar_loja('humberto',10)
lj1.avaliar_loja('humberto',8)
lj2 = Loja('Loja do renato','Francisco morato')
lj2.avaliar_loja('ronaldo',10)
lj2.avaliar_loja('ronaldo',8)
Loja.listar_lojas()