from jogoteca import db

class Jogos(db.Model):
    id = db.Column(db.Integer,primary_key= True)
    nome = db.Column(db.String(50),nullable = False)
    categoria = db.Column(db.String(40),nullable = False)
    console = db.Column(db.String(20),nullable = False)

    # def __repr__(self):
    #     return '<Nome %r>'% self.nome

class Usuarios(db.Model):
    nickName = db.Column(db.String(8),primary_key = True,nullable= False)
    nome = db.Column(db.String(20),nullable = False)
    senha = db.Column(db.String(100),nullable = False)