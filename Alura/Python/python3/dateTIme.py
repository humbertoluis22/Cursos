from _datetime import datetime,timedelta
from datasBr import DatasBr

cadastro = DatasBr()
# print(cadastro.mes_cadastro())
# print(cadastro.dia_semana())

'''

hoje = datetime.today()
hoje_formatado = hoje.strftime("%d/%m/%Y %H:%M")
print(hoje)
print(hoje_formatado)
print(type(hoje_formatado))
'''

print(cadastro)
print(cadastro.tempo_cadastro())
