class Programa:
    def __init__(self, nome, ano ):
        self._nome = nome.title()
        self.ano = ano
        self._likes = 0

    @property
    def likes(self):
        return self._likes

    def dar_like(self):
        self._likes += 1

    @property
    def nome(self):
        return self._nome

    @nome.setter
    def nome(self, novo_nome):
        self._nome = novo_nome.title()

    def __str__(self):
        return f"{self._nome} - {self.ano} - {self._likes} likes"


class Filme(Programa):
    def __init__(self, nome, ano,duracao):
        super().__init__(nome,ano)
        self.duracao = duracao

    def __str__(self):
        return f"{self._nome} - {self.ano} - {self.duracao}  - {self._likes} likes"


class Serie(Programa):
    def __init__(self,nome,ano,temporada):
        super().__init__(nome,ano)
        self.temporada = temporada

    def __str__(self):
        return f"{self._nome} - {self.ano}- {self.temporada} temporada - {self._likes} likes"


class PLaylist:
    def __init__(self,nome, programas):
        self.nome = nome
        self._programas = programas

    def __getitem__(self, item):
        return self._programas[item]

    @property
    def listagem(self):
        return self._programas
    def __len__(self):
        return len(self._programas)




vingadores = Filme('vigandores - guerra infinita',2018,160)
atlanta = Serie('atlanta',2018,2)
tmep = Filme('todo mundo em panico', 1999,100)
demolidor= Serie('demolidor',2016,2)


vingadores.duracao ="2 horas e 40 minutos"
vingadores.dar_like()
tmep.dar_like()
demolidor.dar_like()
demolidor.dar_like()
atlanta.dar_like()
atlanta.dar_like()

atlanta.nome = "nova atlanta"

filmes_e_serie = [vingadores,atlanta,demolidor,tmep]
playlist_fim_de_semana = PLaylist('fim de semama', filmes_e_serie)
print(f"tamanho da playlist: {len(playlist_fim_de_semana)}")

for programa in playlist_fim_de_semana.listagem:
    print(programa)

print(f'ta ou não ta? {demolidor in playlist_fim_de_semana}')