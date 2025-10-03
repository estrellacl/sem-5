while True:
    num = int(input("Ingrese un numero : "))
    suma = 0

    for i in range(1, num+1):
        suma += i 
        print(i,end=" ")
    print("\n\n Suma:" , suma)

    opc = input(" \n ¿Desea continuar? ( presioen  N para salir):")

    if(opc == "N"): break