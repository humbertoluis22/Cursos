import re
from TelefonesBr import TelefonesBr


# padrao = "[0-9][a-z][0-9]"
# texto = "123 1a2 23c nn3"
# resposta = re.search(padrao,texto)
# print(resposta.group())

#procurando email
# padrao= "\w{5,50}@[a-z].\w{2,3}.\w{2,3}"
# texto = " meu nome é humberto e meu email é humbertoluis2013@gmail.com.br"
# resposta = re.search(padrao,texto)
# print(resposta.group())

#padrao de telefone fixo e celular

# padrao = "[0-9]{2}[0-9]{4,5}[0-9]{4}"
# texto = "123 4323-4324  1174390710"
# reposta = re.search(padrao,texto)
# print(reposta.group())



#testando classe

telefone = "552126481234"
telefone_objeto = TelefonesBr(telefone)
print(telefone_objeto)

