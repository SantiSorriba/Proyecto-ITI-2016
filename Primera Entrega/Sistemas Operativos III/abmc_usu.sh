#!/bin/bash
opc=0;
function menu {
clear
echo "********** ABMC USUARIOS **********"
echo "1) Agregar Usuario"
echo "2) Borrar Usuario"
echo "3) Modificar Usuario"
echo "4) Consultar Usuario"
echo "5) Volver"
}
while [ $opc -ne 5 ]
do
menu
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
	  read -p "Error, verifique su opcion"
	  menu
	  ;;
 esac
done
