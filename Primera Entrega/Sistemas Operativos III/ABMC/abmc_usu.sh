#!/bin/bash
opc=0;

function menu_usu {
clear
echo "********** ABMC USUARIOS **********"
echo "1) Agregar usuario"
echo "2) Borrar usuario"
echo "3) Modificar usuario"
echo "4) Consultar usuario"
echo "5) Volver"
}

while [ $opc -ne 5 ]
do
menu_usu
read -p "Opcion: " opc

 case $opc in

 	1)
	  . agregar_usu.sh
	  ;;

	2)
	  . borrar_usu.sh
	  ;;

	3)
	  . modificar_usu.sh
	  ;;

	4) 
	  . consultar_usu.sh
	  ;;

	5)
	  . principal.sh
	  ;;

	*)
	  read -p "Error, verifique su opcion."
	  menu_usu
	  ;;
 esac
done
