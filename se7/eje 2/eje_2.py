import random
secreto = random.randint(1,20)
intentos= 3 

print("************************************************")
print("*     BIENVENIDO AL JUEGO ADIVINADOR      ******")
print("*                                         ******")
print("* 1. UD.DEBERA ADIVINAR EL NUMERO ENTRE 1 Y 20 *")
print("* 2. UD. TIENE 3 INTENTOS                      *")
print("*3.POR CADA FALTA SE OTORGAERA UNA PISTA       *")
print("************************************************")

while(intentos > 0 ):
    num = int(input(f"\nIngrese numero (intento {intentos}):"))

    if num == secreto:
        print("\nFelicidades adivinaste!")
        break
    else:
        intentos -=1
        if num < secreto: print("El numero es mayor.")
        else: print("el  numero es menor ")

else:print(f"\n no lograste adivinar el numero {secreto} ")



