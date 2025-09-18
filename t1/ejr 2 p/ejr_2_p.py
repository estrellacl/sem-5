
cat =input("Ingrese la categoria:")

pro= float(input("Promedio:"))

if cat == "A":
    pension = 550;
elif cat == "B":
    pension = 500
elif cat == "C":
    pension = 460;
else:                        #cat=D
     pension = 400


if pro >= 0 and  pro <= 13.99:
    descuento = 0
elif pro <= 15.99:
    descuento = 0.10 * pension

elif pro <= 17.99:
    descuento = 0.12 * pension
else:
    descuento =0.15 * pension

nuevapension = pension - descuento


print ("pension : " , pension)
print("Descuento " ,descuento)
print("nueva pension :"  , nuevapension)

