#!/bin/bash
usuario="";
clear
echo "********** Consultar Usuario **********"
read -p "Ingrese el login del usuario a consultar: " usuario
busqueda=`cut -d ":" -f1 /etc/passwd | grep $usuario` 
if [ $? == 0 ];
then
resultado=`grep $usuario /etc/passwd`
echo "Datos de $usuario : $resultado"
else
echo "Ese usuario no existe."
fi
read -p "Presione enter para continuar..."
. abmc_usu.sh
