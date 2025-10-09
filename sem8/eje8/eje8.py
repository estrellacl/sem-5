import random
canpares=0
sumapares=0
canimpar=0
suma=0
sumaimpares=0
while True:
    aleatorio = random.randint(1000,9999)
    print(aleatorio)
    suma += aleatorio

    if aleatorio %2 == 0:
        canpares+=1
        sumapares += aleatorio

    else:
        canimpar +=1
        sumaimpares += aleatorio
    
    if aleatorio%2==1 and aleatorio<1800:
         break

 
