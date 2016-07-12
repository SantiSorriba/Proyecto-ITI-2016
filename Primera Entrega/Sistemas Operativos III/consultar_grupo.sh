#!/bin/bash
num_grupo="";
nom_grupo="";
opc=0;
function menu {
clear
echo "********** Consultar Grupo **********"
echo "1) Buscar por numero"
echo "2) Buscar por nombre"
}
while [ $opc -ne 2 ]
do
menu
read -p "Opcion: " opc
case $opc in
	1)
	  read -p "Ingrese el numero del grupo: " num_grupo
	  busqueda=`cut -d ":" -s -f3 /etc/group | grep $num_grupo`
	  if [ $? == 0 ];
	  then
	  resultado=`grep $num_grupo /etc/group`
	  read -p "Datos del grupo Nº $num_grupo: $resultado" 
	  else
	  read -p "Ese grupo no existe."
	  menu
	  fi
	  ;;
	2)
	  read -p "Ingrese el nombre del grupo: " nom_grupo
	  busqueda=`cut -d ":" -f1 /etc/group | grep $nom_grupo`
	  if [ $? == 0 ];
          then
          resultado=`grep $nom_grupo /etc/group`
          read -p "Datos del grupo $nom_grupo: $resultado"
          else
          read -p "Ese grupo no existe."
	  menu
          fi 
          ;;
	*) 
	  read -p "Error, verifique su opcion..."
	  menu
	  ;; 
 esac
done
read -p "Presione enter para continuar..."


  
