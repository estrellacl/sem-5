angulo = float(input("Angulo"))

if angulo >= 0 and  angulo <= 360:
            
   if angulo == 0:
      clasificacion = "Nulo"
   elif angulo <= 90:
      clasificacion = "Agudo"
   elif angulo == 90:
      clasificacion = "Recto"
   elif angulo < 180:
      clasificacion = "Obtuso"
   elif angulo == 180:
      clasificacion = "llano"
   elif angulo < 360:
       clasificacion = "concavo"
   else:
      clasificacion = "Completo"

   print("el angulo es  :" ,  clasificacion)
else:
    print("el angulo es incorrecto ")
    

 
           