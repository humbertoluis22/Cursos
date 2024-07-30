url ="bytebank.com/cambio?moedaDestino=dolar&moedaOrigem=real"
print(url)

#sanitização da url
url = url.strip()

#validação da url
if url == "":
    raise ValueError("a url esta vazia")


#separa base e os parametros
indice_interrogacao = url.find("?")
url_base = url[0:indice_interrogacao]
print(url_base)


##buca valor  de um parametro
url_parametros = url[indice_interrogacao + 1:]


parametro_buca= 'moedaDestino'
indice_parametro = url_parametros.find(parametro_buca)


indice_valor = indice_parametro + len(parametro_buca) + 1
indice_e_comercial = url_parametros.find('&',indice_valor)

if indice_e_comercial == -1:
    valor = url_parametros[indice_valor:]
else:
    valor = url_parametros[indice_valor:indice_e_comercial]
print(valor)