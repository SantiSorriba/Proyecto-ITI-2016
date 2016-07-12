#!/bin/bash
opc=0;
function menumodifg {
clear
echo "********** MODIFICAR GRUPO **********"
echo "1) Modificar nombre"
echo "2) Modificar numero"
echo "3) Volver"
}
while [ $opc -ne 2 ]
do
menumodifg
read -p "Opcion: " opc
case $opc in
	1)
	  . modif_nom.sh
	  ;;
	2)
	  . modif_num.sh
	  ;;
	3) 
	  . abmc_grupos.sh
esac
done
