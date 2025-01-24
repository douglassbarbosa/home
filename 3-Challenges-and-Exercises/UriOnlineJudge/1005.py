#Calcule e imprima a variável MEDIA conforme exemplo abaixo, com 5 dígitos após o ponto decimal

consumo1 = float(input())
consumo2 = float(input())

def consumoMedio(cons1,cons2):
    media = ((cons1*3.5) + (cons2*7.5))/(3.5+7.5)
    print("MEDIA = {:0.5f}".format(media))

consumoMedio(consumo1,consumo2)
