from modelos.restaurante import Restaurante
from modelos.cardapio.bebida import Bebida
from modelos.cardapio.prato import  Prato

r1 = Restaurante('PizzaHot','pizza')
bebida_suco = Bebida('suco de melancia',5,'Grande')
prato_pizza = Prato('Pizza de chocolate',50.0,'A melhor pizza doce da região')

r1.adiciona_item_no_cardapio(prato_pizza)
r1.adiciona_item_no_cardapio(bebida_suco)
def main():
    r1.exibir_cardapio

if (__name__ == '__main__'):
    main()
