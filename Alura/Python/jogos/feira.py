
frutas_feira = ["abacate","melancia","banana","morango"]
desejos = frutas_feira.append(input("qual fruta vc deseja adicionar a feira?"))
index = 0

frutas_feira.append("uva")

fruta_desejada = input("qual fruta você deseja? ")

for frutas in frutas_feira:
    print(frutas)
    if fruta_desejada in frutas:
         print("a fruta q vc deseja esta na posição")
         frutas_feira[index] = frutas
    index +=1
    print(frutas_feira)
else:
    print(f"a fruta {fruta_desejada} não tem na feira")

