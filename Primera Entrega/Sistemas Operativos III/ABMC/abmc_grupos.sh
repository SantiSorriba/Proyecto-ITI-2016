#!/bin/bash
opc=0;

function menu_grupos {
clear
echo "********** ABMC GRUPOS **********"
echo "1) Agregar grupo"
echo "2) Borrar grupo"
echo "3) Modificar grupo"
echo "4) Consultar grupo"
echo "5) Volver"
}

while [ $opc -ne 5 ]
do
menu_grupos
read -p "Opcion: " opc

 case $opc in

 	1)
	  . agregar_grupo.sh
	  ;;

	2)
	  . borrar_grupo.sh
	  ;;

	3)
	  . modificar_grupo.sh
	  ;;

	4) 
	  . consultar_grupo.sh
	  ;;

	5)
	  . principal.sh
	  ;;

	*)
	  read -p "Error, verifique su opcion."
	  menu_grupos
	  ;;
 esac
done
