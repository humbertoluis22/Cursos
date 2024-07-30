#criando seu primeiro modulo
def soma():
    print('essa função vai somar valores')

def mult():
    print('essa função vai multiplicar valores')

'''def find_index(to_find,item):
  for i, valor in enumerate(to_find):
    if valor == item:
      return 1
  return -1'''
def find_index (to_find,item):
  for i, valor in enumerate(to_find):
    if valor == item:
      return 1
  return -1