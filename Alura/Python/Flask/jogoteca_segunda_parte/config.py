import os

# app.secret_key = 'alura'
SECRET_KEY = 'alura'

# app.config['SQLALCHEMY_DATABASE_URI'] = \
#     '{SGBD}://{usuario}:{senha}@{servidor}/{database}'.format(
#         SGBD = 'mysql+mysqlconnector',
#         usuario = 'root',
#         senha = 'Cereja%4030',
#         servidor = 'localhost',
#         database = 'jogoteca'
#     )


SQLALCHEMY_DATABASE_URI= \
    '{SGBD}://{usuario}:{senha}@{servidor}/{database}'.format(
        SGBD = 'mysql+mysqlconnector',
        usuario = 'root',
        senha = 'Cereja%4030',
        servidor = 'localhost',
        database = 'jogoteca'
    )
#ao fazer conexao com o banco, caso sua senha tenha caracter especial 
#você deve substituí-lo pelo seu respectivo código URL. Por exemplo, um espaço deve ser substituído por %20.


UPLOAD_PATH = os.path.dirname(os.path.abspath(__file__)) + '/uploads'