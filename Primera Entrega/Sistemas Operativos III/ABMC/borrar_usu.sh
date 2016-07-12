#!/bin/bash
usuario="";
opc=0;
clear
echo "********** BORRAR USUARIO **********"
read -p "Ingrese el nombre de usuario a borrar: " usuario
busqueda=`cut -d ":" -f1 /etc/passwd | grep $usuario`
if [ $? == 0 ];
then
echo "1) Borrar solo el usuario"
echo "2) Borrar el usuario y todo su contenido (Incluyendo home)"
echo "3) Volver"
read -p "Opcion: " opc
case $opc in
	1)
	  . borrar_usu1.sh
	  ;;
	2)
	  . borrar_usu2.sh
	  ;;
	3)
	  . abmc_usu.sh
	  ;;
esac
else
read -p "Error, ese usuario no existe."
. abmc_usu.sh
fi
