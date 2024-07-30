import random

def jogar_adivinhacao():

    print("**********************************")
    print("bem vindo ao jogo de adivinhação!!")
    print("**********************************")

    numero_secreto = random.randrange(1,101)
    rodada = 1
    total_tentivas = 0
    pontos = 1000
    print(numero_secreto)

    print("Qual o nivel de dificuldade? ")
    print("(1)Facil (2)Medio (3)Dificil")

    nivel= int(input("escolha o nivel de dificuldade: "))

    if(nivel ==1):
        total_tentivas = 20
    elif(nivel == 2):
        total_tentivas = 10
    else :
        total_tentivas = 5


    for rodada in range (1,total_tentivas +1):
        print("Tentativa {} de  {}".format(rodada, total_tentivas))
        chute_str = input("digite um numero entre 1 e 100: ")
        chute = int(chute_str)
        print("vc digitou: ", chute_str)

        if(chute < 1 or chute > 100):
            print("algo deu errado!! o numero precisa ser entre 1 e 100!!")
            continue

        acertou = chute == numero_secreto
        maior = chute > numero_secreto
        menor = chute < numero_secreto


        if(acertou):
            print(f"voce acertou!! e fez {pontos} pontos")
            break
        else:
            if(maior):
                print("voce errou!!o chute foi maior do que o numero secreto!")
            elif(menor):
                print("voce errou!!o chute foi menor do que o numero secreto!")

            pontos_perdidos = abs(numero_secreto - chute)
            pontos -= pontos_perdidos

    print("FIM DO JOGO!!")

if(__name__ == "__main__"):
    jogar_adivinhacao()