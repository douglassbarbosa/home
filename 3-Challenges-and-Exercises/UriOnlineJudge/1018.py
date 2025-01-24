
valor = int(input())
cem = int(valor/100)
print(cem,"nota(s) de R$ 100,00")
cinquenta = int((valor%100)/50)
print(cinquenta,"nota(s) de R$ 50,00")
vinte = int(((valor%100)%50)/20)
print(vinte,"nota(s) de R$ 20,00")
dez = int((((valor%100)%50)%20)/10)
print(dez,"nota(s) de R$ 10,00")
cinco = int(((((valor%100)%50)%20)%10)/5)
print(cinco,"nota(s) de R$ 5,00")
dois = int((((((valor%100)%50)%20)%10)%5)/2)
print(dois,"nota(s) de R$ 2,00")
um = int((((((valor%100)%50)%20)%10)%5)/1)
print(um,"nota(s) de R$ 1,00")


