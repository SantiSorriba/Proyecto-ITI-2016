#!/bin/bash
opc=0;

function menu {
clear
echo "********** ABMC S.I.G.A.T **********"
echo "Seleccione con que desea trabajar:"
echo "1) Usuarios"
echo "2) Grupos"
echo "3) Salir"
}

while [ $opc -ne 3 ]
do
menu
read -p "Opcion: " opc

 case $opc in

	1)
	  . abmc_usu.sh
	  ;;

	2)
	  . abmc_grupos.sh
	  ;;

	3) 
	  clear
	  read -p "Presione enter para salir..."
	  exit 
	  ;;

	*)
	  read -p "Error, verifique su opcion."
	  menu
	  ;;
 esac
done
