lado1 = float(input("Digite o valor 1º lado: "))
lado2 = float(input("Digite o valor 2º lado: "))
lado3 = float(input("Digite o valor 3º lado: "))

angulo1 = int(input("Digite o valor do 1º ângulo: "))
angulo2 = int(input("Digite o valor do 2º ângulo: "))
angulo3 = int(input("Digite o valor do 3º ângulo: "))

if(lado1 + lado2 < lado3 or lado2 + lado3 < lado1 or lado1 + lado1 + lado3 < lado2):
    print("Triângulo inválido!")
elif(lado1 != lado2 and lado2 != lado3 and lado3 != lado1):
    print("Triângulo Escaleno")
elif(lado1 == lado2 and lado1 == lado3 and lado2 == lado3):
    print("Triângulo Equilatero")
elif(lado1 == lado2 or lado1 == lado3 or lado2 == lado3):
    print("Triângulo Isósceles")
else:
    print("Dados inválidos")
