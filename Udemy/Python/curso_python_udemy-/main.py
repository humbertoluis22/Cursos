'''ano_nascimento=int(input('digite o ano q vc nasceu: '))
ano_atual=2022
idade= ano_atual - ano_nascimento
print('vc tem ',idade,' anos de idade')'''

#slice
'''fruta= 'abacaxi'
print(fruta[2:5])
valor=str('99.89')
print(valor[2:])'''

#format str
'''nome=input('digite seu nome: ')
sobrenome=input('digite seu sobrenome: ')
profissao= input('digite sua profissão: ')
texto= f'o {nome} {sobrenome} é um excelente [{profissao}].'
print(texto)'''

#metados para strings
'''frase= 'eu adoro comida Caseira'
print(frase.strip())
print(frase.split())
print(frase.capitalize())
print(frase.lower())
print(frase.upper())
print(frase.find('a'))
print(frase.replace('Caseira','feita em casa'))'''

#operadores matematicos sequencias
'''
parenteses
exponenciais
multiplicação e divisão
sub e adc
'''

#operadores de comparação
'''valor= 10 ==10
print(valor)
valor2 = 10!= 11
print(valor2)
valor3= 11 <= 14
print(valor3)
valor4= 12>=9
print(valor4)
valor5= 14< 17
print(valor5)
valor6= 89>903
print(valor6)'''

#operadores de atribuição
'''x= 10
#x +=5
#x -= 6
#x %= 4
#x *= 65
#x/=3
print(x)'''

#if, else, elif

'''velocidade=int(input('DIGITE A VELOCIDADE ATUAL: '))
if velocidade >=110:
  print('velocidade a cima da media!!!!')
  print('favor reduzir a velocidade')
elif velocidade <= 50:
  print('velocidade mt abaixo da media!!!')
  print('favor acelar mais!!!!')
else:
  print('velocidade OKAY')
'''

#operadores logicos and/ or
'''renda_acima_5mil = False
nome_limpo = False
'''

'''if  renda_acima_5mil and nome_limpo:
  print('financiamento aprovador ')
else:
  print('financiamento negado ')
'''
'''
if renda_acima_5mil or nome_limpo:
  print('financiamento aprovado')
else:
  print('financiamento negado')
'''

#assistir seção 6 e 7 quarta feira
#assistir seção 8 quinta feira
#assistir 5 seçoes por dia ate segunda feira





#operador ternario 

'''idade= int(input('digite sua idade: '))

resultado= 'voto permitido' if idade >=16 else 'voto negado'
print(resultado)'''

#multiplos operadores de comparaçãobject
'''valor = 44
#primeiro if é a forma simplificada 
if 20<=valor <40:
  print('produto aceito ')
else:
  print('produto recusado')'''


'''if valor >= 20 and valor <=40:
  print('produto foi aceito')
else:
  print('produto recusado')'''


#for loop numero 
'''
for numero in range(6):
  print(numero)
for numer in range(2,99):
  print(numer)
for i in range (1,20,2):
  print(i)'''


#for loop em letras strings
'''for letra in 'google':
  print(letra)'''
'''palavra = 'teclado'
for letra in palavra:
  print(f'na palavra {palavra} tem a letra {letra}.')
  '''
'''palavra=str(input('digite uma palavra: '))
for letra in palavra:
  print(f'na palavra {palavra} tem a letra {letra}.')'''

#For loop em if e else
'''compra_confirmada = True
dados_compra = 'seu pedido de R$ 23 reias foi confirmado e esta pronto para entrega'

for pedido in range (3):
  if compra_confirmada:
    print(dados_compra)
    print('detalhes enviado por e-mail')
    break
  else:
    print('falha na compra')'''

#loop dentro de outro Loop

'''for numero1 in range (5):
  print(numero1)
  for numero2 in range(4):
    print(numero2)'''

'''for numero1 in range (1,6):
  print('produto' , str(numero1))
  for  i in range(5):
    print(numero1,i)
'''

#looping separando string
'''palavra= 'fantastico'
for espace in palavra:
  print(espace,end=" ")'''

#loop for criando um retangulo
'''coluna =6 
linha=6
simbolo="*"

for l in range (linha):
  for c in range (coluna):
    print(simbolo, end="")
  print()
  '''

#criando loop com while
'''valor=100
dia =1 
while valor >= 20 :
  print(f'meu produto sera vendido pelo valor {valor} no dia {dia}.')
  dia +=1
  valor -=5'''

#criando condiçoes para o while loop
"""valor=int(input('digite o seu valor em R$: '))
while valor > 20:
  valor= (valor * 0.10)+ valor
  print(f'o valor final do seu produto sera de R$:{valor}')
  break"""

#criando uma função

'''def valor10():
  valor =int(input("digite o valor do produto: "))
  while valor > 20:
    valor= (valor*0.10)+valor
    print( f'o valor final do produto é de r$:{valor}')
    break
print('o valor da carne é de 10 reais')
valor10()
'''

#funçoes com parametros e argumentos
'''def boas_vindas(nome,quantidade):
  print(f'olá {nome}')
  print(f'temos {str(quantidade)} de laptops no estoque')
boas_vindas('marcos',5)
boas_vindas('maria',3)
boas_vindas('jose',7)
  '''
#fuçoes default(definido) e notdefault(nao definido)

'''def boas_vinda(quantidade,nome= 'marcos'):
  print(f'olá {nome}')
  print(f"temos {quantidade} de pcs no estoque")

boas_vinda(4)'''

#print x return em uma função

'''def cliente1(nome):
  print(f'olá {nome}')

def cliente2 (nome):
  return f'olá {nome}'

  
cliente1('maria')
print(cliente2('jose'))'''

# vairios argumentos xargs com numeros
'''def soma (*numeros):
  resultado=0
  for num in numeros:
    resultado += num
  return resultado
x = soma(2,5,6,7,7)
print(x)'''

'''def mult (*numeros):
  resultado=1
  for mul in numeros:
    resultado *= mul
  return resultado
x= mult(3,89783)
print(x)'''

# varios argumentos xargs nomeando parametros 
#parametro tudo q é definido depois do = e antes
'''def agencia(**carro):
  return carro

print(agencia(cor= 'vermelha',marca= 'gol', ano=1999, placa='dfgr1234' ))'''

#importando modulos
'''import math
print(math.factorial(4))'''

# listas, manipulando lista e funçoes dentro de lista
'''cidades=['sao paulo', ' salvador','rio de janeiro']
print(cidades[0])
cidades[0]='amazonia'
cidades.append('terezina')
print(cidades)
cidades.remove(' salvador')
print(cidades)
cidades.insert(1,'joao dias')
print(cidades)'''

#concatenando listas
'''numeros=[1,2,3,4,5,6]
numero1=numeros * 5
print(numero1)
letras=['a','b','c','d']
final=numeros + letras
print(final)
numeros.extend(letras)
print(numeros)
listas_listas=[['item1','item2'],['item3','item4']]
print(listas_listas[0])
print(listas_listas[0][0])'''

#extraindo varias de uma lista
'''produto=['banana','maça','feijão','arroz',1,2,3,4,5]
#item1,item2,item3,item4=produto
item1,item2,item3,*outros=produto
print(item1)
print(item2)
print(item3)
print(outros)'''

#looping dentro de uma lista
'''valores=[30,309,23,43,54,65,67]
for i in valores:
  print(f'o valor final do produto é de R${i}')
'''
#verigficando itens em uma lista
'''cor_cliente=input('digite a cor desejada: ')
cor= ['vermelho','amarelo','azul']
if cor_cliente.lower() in cor:
  print('temos essa cor em estoque')
else:
  print('n temos essa cor no estoque')'''

#agregando duas lista com a funçao zip
'''cores=['amarelo','verde','azul']
numeros=[10,23,54]
duas_listas=zip(cores,numeros)
print(list(duas_listas))'''

#adicionando input as listas
'''fruta_usuario=input('digite as frutas separadas por , : ')
fruta_lista= fruta_usuario.split(', ')
print(fruta_lista)'''

#trabalhando com arrays 
'''from array import array
letras=array('u',['s','a','u','d','a','d','e'])
print(letras)
numeros_1=array('i',[1,2,3,4,5,6,7,8])
print(numeros_1)
numeros_2=array('f',[1.34,2.34,5.3])
print(numeros_2)'''

#set(lista)
'''list1=[10,20,30,40,50]
list2=[10,20,60,70]
num1=set(list1)
num2=set(list2)
print(num1 | num2)#union
print(num1 - num2)#difference
print(num1 ^ num2)#simetryc difference
print(num1 & num2)#end'''

#funçoes em set
'''s1={1,2,3,4,5,6}
s1.add(10)
s1.update([7,4,5,8,9,11])
s1.remove(11)
s1.discard(90)
print(s1)'''

#set com str
'''pl1={'a','b','c'}
pl2={'d','a','f'}
pl3={'g','c','f'}

pl4= pl1.union(pl3)
#pl4= pl1.difference(pl3)
#pl4=pl1.symmetric_difference(pl3)
#pl4=pl1.intersection(pl3)
print(pl4)
'''

#dicionario 
'''aluno={'nome':'isa','idade':18,'nota_final':7, 'situação':'aprovada'}
print(aluno)
print(aluno['nota_final'])'''

#dicionarios
'''aluno={'nome':'jose', 'idade':18,'nota_final':6}
#aluno['nome'] = 'humberto'
aluno.update({'nome':'maria'})
print(aluno.get('rua','n encontrado'))
print(aluno)
'''

#looping dentro de dicionario
'''aluno = {'nome':'gabi','idade':17,'nota_final':10}
#for x in aluno:
# print(aluno)
for  keys, values  in aluno.items():
  print(keys,values)'''

#Visualizandom itens, keys e values
'''aluno = {'nome':'gabi','idade':17,'nota_final':10,"aprovado":True,'materias':['matematica,ingles']}
print(aluno)
print(aluno['materias'])
print(aluno.values())
print(aluno.get('materias'))
print(len(aluno))
print(aluno.keys())
print(aluno.items())'''

#função lambda, funçao pequena e sem nome
'''soma10 = lambda x,y : x+y+10
print(soma10(3,5))'''

#lambda dentro de outra funçao
'''def somar(x):
  func = lambda x: x + 10
  return func(x) * 4
print(somar(5))
  '''

#funçao map em uma lista
'''lista1=[1,2,3,4]
def mult(x):
  return x*2
lista2=map(mult,lista1)

print(list(lista2))
  '''

#função map com lambda
'''list1=[1,2,3,4]
print(list(map(lambda x:x*2,list1)))'''

#função filter
'''valores=[12,15,22,40,50]
def remover20(x):
  return x > 20
#print(list(map(remover20,valores)))
print(list(filter(remover20,valores)))
print(list(filter(lambda x: x > 20,valores)))
'''

#lista comprehension
'''lista1=['banana','acabate','melão','abobora','melancia']
#lista2=[]
#for iten in lista1:
#  if 'b' in iten:
#    lista2.append(iten)
lista2=[iten for iten in lista1 if 'b' in iten]
print(lista2)'''

#list comprehension com numeros 
'''valores=[]
for x in range(6):
  valores.append(x*10)

print(valores)'''
'''valor=[x*10 for x in range(9)]
print(valor)
'''

#lista e generator expressions
#generator expressions mais leves para a memoria pq n armazena
#getsizeof funçao do import para saber o tanto de memoria q a função esta utiizando
'''from sys import getsizeof 

numeros=[x*10 for x in range(10)]
print(type(numeros))
print(numeros)
print(getsizeof(numeros)) 


numeros=(x*10 for x in range(10))
print(type(numeros))
print(list(numeros))
print(getsizeof(numeros))'''

#error try e except
'''try:
  letras=['a','b','c']
  print(letras[4])
except IndexError:
  print('index nao encotrado')'''

#trabalhando com try e except com input
'''try:
  num=int(input('digite o valor do produto: '))
  print(num)
except ValueError:
  print('favor digitar somente numeros')'''

#adicionando else e finally
'''try:
  num=int(input('digite o valor do produto: '))
  print(num)
except ValueError:
  print('favor digitar somente numeros')
finally:
  print('codigo esta okay')


else:
  print('valor digitado esta correto!')
  resultado=num *3
  print(resultado)

print('mais codigo abaixo')'''

#criando a primeira classe
'''class funcionario:
  nome='helena'
  sobrenome='oliveira'
  data_nascimento='11/06/1988'
  
usuario1= funcionario()
print(usuario1.nome)'''


#criando objeto dentro de uma classe
    #classe
'''class funcionarios:
  pass
    #criar objeto
usuario1=funcionarios()
usuario2=funcionarios()
    #criar parametros
usuario1.nome='humberto'
usuario1.idade='18'
usuario1.nacionalidade='brasileiro'
usuario2.nome='isabela'
usuario2.idade='19'
usuario2.nacionalidade='brasileira'
    #print
print(usuario1.nacionalidade)
print(usuario2.nome)'''


#criando construtores 
'''class Funcionarios:
  
  def __init__(self,nome,sobrenome,idade):
    self.nome = nome
    self.sobrenome = sobrenome
    self.idade = idade
usuario1=Funcionarios('humberto','oliveira','23')
usuario2=Funcionarios('camili','marques','32')

print(usuario1.nome)
print(usuario2.nome)'''

#adicionando mais funcçoes a classe
'''class funcionarios:
  def __init__(self,nome,sobrenome,datanascimento):
    self.nome=nome
    self.sobrenome=sobrenome
    self.datanascimento=datanascimento
  def nomecompleto(self):
    return self.nome+' '+self.sobrenome
usuario1=funcionarios('guilherme','furtado','04/08/1978')
usuario2=funcionarios('maria','oliveira','13/09/1992')
print(usuario1.nomecompleto())
print(funcionarios.nomecompleto(usuario2))
print(usuario2.nome)'''

#calculando a idade do funcionario da classe
'''from datetime import datetime
class funcionarios:
  def __init__(self,nome,sobrenome,datanascimento):
    self.nome=nome
    self.sobrenome=sobrenome
    self.datanascimento=datanascimento
  def nomecompleto(self):
    return self.nome+' '+self.sobrenome

  def idade(self):
    ano_atual=datetime.now().year
    self.datanascimento= int(ano_atual - self.datanascimento)
    return self.datanascimento
    
 
usuario1=funcionarios('guilherme','furtado',1998)
usuario2=funcionarios('maria','oliveira',2000)

print(funcionarios.nomecompleto(usuario2))
print(funcionarios.idade(usuario1))
print(funcionarios.idade(usuario2))'''




#importando modulos

'''import funções
funções.mult()'''

'''from funções import soma, mult
mult()
soma()'''

#importando packages
''''from items.cadastro import cliente
cliente()'
'''
# aplicando um modulo
'''from funções import find_index

lista1=['a','b','c','d']
var1=find_index(lista1,'b')
print(var1)'''

#treinando construtores
'''from datetime import datetime

class funcionarios:
  def __init__(self,nome,sobrenome, data_nascimento):
    self.nome=nome
    self.sobrenome=sobrenome
    self.data_nascimento = data_nascimento
  def nomecompleto(self):
    return self.nome+" "+self.sobrenome

  def idade(self):
    ano_atual=datetime.now().year
    self.data_nascimento= int(ano_atual - self.data_nascimento)
    return self.data_nascimento
    
operador=funcionarios('humberto','luis',2001)
print(operador.sobrenome)
print(operador.nomecompleto())
print(operador.idade())'''

#desafios
'''temperatura= int(input('digite a temperatura da carne: '))
if temperatura < 48:
  print('cozinhar por mais alguns minutos')
elif temperatura in range(48,53):
  print('selada')
elif temperatura in range(54,59):
  print('ao ponto para mal')
elif temperatura in range(60,64):
  print('ao ponto')
elif temperatura in range(65,70):
  print('ao ponto para bem')
else :
  print('bem passada')'''

#latas de tintas desafio
'''rendimento=int(input('digite o rendimento: '))
altura=int(input('digite a altura: '))
largura=int(input('digite a largura: '))

def calculo_tintaa():
  area= altura * largura
  total = area/rendimento
  print(f'vc precisara de {total} latas de tintas')
calculo_tintaa()'''

#carros desafio
'''#carro funcionarios
funcionarios=['humberto','henrique','guilherme','isabela','maria','joao']
turnodia=['humberto','henrique','maria']
turnonoite=['guilherme','isabela','joao']
temcarro=['humberto','isabela','maria','guilherme']

#funcionarios que tem carro e trabalham de dia
lista=set(temcarro).intersection(turnodia)
print(lista)
#funcionarios que possuem carro e trabalham a noite
lista2=set(temcarro).intersection(turnonoite)
print(lista2)
#funcionarios que não tem carro 
lista3=set(funcionarios).difference(temcarro)
print(lista3)'''

#calculando imc
altura=float(input('digite a sua altura: '))
peso=float(input('digite o seu peso: '))
calculoimc=peso/(altura/100)**2
imc=calculoimc
if imc <= 18.5:
  print('magreza')
elif imc >=18.6 and imc < 24.9:
  print('normal')
elif imc >= 25 and imc <29.9:
  print('sobrepeso')
elif imc >=30 and imc<39.9:
  print('obesidade')
else:
  print('obesidade grave')

