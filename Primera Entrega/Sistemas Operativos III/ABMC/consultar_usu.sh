#!/bin/bash
usuario="";
clear
echo "********** CONSULTAR USUARIO **********"
read -p "Ingrese el login del usuario a consultar: " usuario
busqueda=`cut -d ":" -f1 /etc/passwd | grep $usuario`
if [ $? == 0 ];
then
finger $usuario
read -p "Presione enter para continuar..."
. abmc_usu.sh
else
read -p "Error, ese usuario no existe."
. abmc_usu.sh
fi
