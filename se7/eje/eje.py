p = i = 0
while True:
   num = int(input("Ingerese numero:"))

   if num < 0: break
   if num % 2 == 0 : p+=1
   else : i +=1

print("\nCantidad de pares:" , p )
print("Cantidad de impares:" , i )
