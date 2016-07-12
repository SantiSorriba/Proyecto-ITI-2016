#!/bin/bash
opc=0;
function menu {
clear
echo "********** ABMC GRUPOS **********"
echo "1) Agregar Grupo"
echo "2) Borrar Grupo"
echo "3) Modificar Grupo"
echo "4) Consultar Grupo"
echo "5) Volver"
}
while [ $opc -ne 5 ]
do
menu
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
	  menu
	  ;;
	*)
	  read -p "Error, verifique su opcion."
	  menu
	  ;;
 esac
done
