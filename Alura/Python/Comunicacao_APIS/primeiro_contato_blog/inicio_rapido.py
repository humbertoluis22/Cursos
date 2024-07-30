#material do blog https://requests.readthedocs.io/projects/pt/pt-br/latest/user/quickstart.html#fazer-uma-requisicao

import requests

response = requests.get('https://docs.github.com/v3/activity/events/#list-public-events')
print(response.status_code) # resposta da requisção
# print(response.text)


"""
    r = requests.post('http://httpbin.org/post')
    r = requests.put("http://httpbin.org/put")
    r = requests.delete("http://httpbin.org/delete")
    r = requests.head("http://httpbin.org/get")
    r = requests.options("http://httpbin.org/get")
"""

# enviando um dado  da query string da URL com o paramns
"""
    payload = {'chave1':'valor1','chave2':'valor2'}
    r = requests.get('http://httpbin.org/get',params = payload)
"""

# verificando se a url foi correntamente gerada
"""
    print(r.url)
"""

#codificação Requests / mudá-la
"""    
    print(response.text) #conteudo da resposta
    print(response.encoding) # codificaçao
    response.encoding = 'mbcs' #novo cof
    print(response.text)
"""

#respota em json
#se lidar com dados JSON
'''
    jsonn = response.json()
    print(jsonn)
'''

