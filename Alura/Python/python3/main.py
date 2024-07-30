from Cpf_Cnpj import Documento
from validate_docbr import  CNPJ
# cpf = 12354547232
# objeto_cpf = Cpf(cpf)
# print(objeto_cpf)
#


# cpf_um = Cpf("01234567890")
# print(cpf_um)

#exemplo_cnpj = "37550529000199"
exemplo_cpf = "92457977088"

# cnpj = CNPJ()
# print(cnpj.validate(exemplo_cnpj))


documento = Documento.cria_documento(exemplo_cpf)
print(documento)