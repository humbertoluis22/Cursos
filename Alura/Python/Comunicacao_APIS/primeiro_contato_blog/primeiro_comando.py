## pip install requests - primeiro efetuar a instalação da lib
#importar lib
import requests 

response = requests.get('https://api.github.com',auth=('user','pass')) # auth = utilizado como parametro opcional para acessar links protegidos

if response.status_code == 200:
    #imprimit conteudo da requisição
    """print(response.text)"""
    print(response.encoding)
    print(response.json())
else:
    #imprimir mensagem de erro 
    print('erro ao fazer a comunicação',response.status_code)
