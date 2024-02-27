lado1 = float(input("Digite o valor 1º lado: "))
lado2 = float(input("Digite o valor 2º lado: "))
lado3 = float(input("Digite o valor 3º lado: "))

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
