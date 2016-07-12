#!/bin/bash
usuario="";
opc=0;
clear
echo "********** Borrar Usuario **********"
read -p "Ingrese el nombre de usuario a borrar: " usuario
verif_usu=`cut -d ":" -f1 /etc/passwd | grep $usuario`
if [ $? == 0 ];
then
echo "1) Borrar solo el usuario"
echo "2) Borrar el usuario y todo su contenido (Incluyendo home)"
read -p "Opcion: " opc
case $opc in
	1) 
	  sudo userdel $usuario
	  read -p "Usuario borrado. Presione enter para continuar..."
	  . abmc_usu.sh
	  ;;
	2)
	  sudo userdel -r $usuario
	  read -p "Usuario borrado. Presione enter para continuar..."
	  . abmc_usu.sh
	  ;;
 esac
else
read -p "Error, ese usuario no existe o ya fue borrado."
. abmc_usu.sh
fi
