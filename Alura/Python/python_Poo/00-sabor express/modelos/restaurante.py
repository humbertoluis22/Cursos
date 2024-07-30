#  ativo(self):
# listar_restaurantes(cls)    alternar_estado(self):
#media_avaliacoes property      receber_avaliacao
from modelos.avaliacao import Avaliacao
from modelos.cardapio.item_cardapio import Item_cardapio
from modelos.cardapio.prato import  Prato
from modelos.cardapio.bebida import Bebida


class Restaurante:
    restaurantes =  []

    def __init__(self,nome, categoria):
        self._nome = nome
        self._categoria  = categoria
        self._ativo = False
        self._avaliacao =[]
        self._cardapio =[]
        Restaurante.restaurantes.append(self)

    def __str__(self):
        return f'{self._nome} | {self._categoria} | {self._ativo}'

    @property
    def ativo (self):
        return  f'ativo' if self._ativo else 'não esta ativo'


    def alternar_estado(self):
        self._ativo = not self._ativo
        print('atualização com sucesso ! ')

    @classmethod
    def listar_restaurantes(cls):
        print(f'Nome'.ljust(23)+'|'+'Categoria'.ljust(23)+'|'+'avaliação'.ljust(24)+'|'+'Estado')
        for restaurante in cls.restaurantes:
            print(f'{restaurante._nome.ljust(22)} | {restaurante._categoria.ljust(22)}| {str(restaurante.media_avaliacoes).ljust(22)} | {restaurante.ativo}')


    def  receber_avaliacao(self,cliente, nota):
        print('avaliado')
        avaliacao = Avaliacao(cliente,nota)
        self._avaliacao.append(avaliacao)

    @property
    def media_avaliacoes(self):
        if not self._avaliacao:
            return 0
        soma_notas = sum(avaliacao._nota for avaliacao in self._avaliacao)
        quantidade_de_notas = len(self._avaliacao)
        media = round(soma_notas / quantidade_de_notas,1)
        return media

    def adiciona_item_no_cardapio(self,item):
        if isinstance(item,Item_cardapio):
            self._cardapio.append(item)

    @property
    def exibir_cardapio(self):
        print(f'Exibindo o cardapio do restaurante {self._nome}')
        for i,item  in enumerate(self._cardapio,start = 1):
            if hasattr(item,'descricao'):
                mensagem_prato =  f'{i} Nome:{item._nome}  | Preço: {item._preco} | Descrição: {item.descricao}'
                print(mensagem_prato)
            else:
                mensagem_bebida = f'{i} Nome: {item._nome}  | Preço: {item._preco} | Descrição: {item._tamanho} '
                print(mensagem_bebida)
