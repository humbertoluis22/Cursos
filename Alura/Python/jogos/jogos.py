import  forca
import adivinhacao

def escolher_jogos():
    print("**********************************")
    print("**********escolha o jogo**********")
    print("**********************************")

    print("(1)adivinhação (2)forca")

    jogo = int(input("qual jogo? : "))

    if(jogo == 1):
        print("jogando adivinhação")
        adivinhacao.jogar_adivinhacao()
    elif(jogo ==2):
        print("jogando forca")
        forca.jogar_forca()


if(__name__ == "__main__"):
    escolher_jogos()