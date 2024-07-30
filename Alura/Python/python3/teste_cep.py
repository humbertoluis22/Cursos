import requests
from acesso_cep import BuscaEndereco

cep = "07807240"
objeto_cep = BuscaEndereco(cep)

print(objeto_cep)

# r = requests.get("https://viacep.com.br/ws/01001000/json/")
# print(r.text)

# a = objeto_cep.acessa_via_cep()
# print(a.json())

bairro,  cidade, uf= objeto_cep.acessa_via_cep()
print(bairro,cidade,uf)