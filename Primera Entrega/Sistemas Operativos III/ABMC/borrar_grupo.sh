#!/bin/bash
grupo="";
opc="";
clear
echo "********** BORRAR GRUPO **********"
read -p "Ingrese el nombre del grupo a borrar: " grupo
busqueda=`cut -d ":" -f1 /etc/group | grep $grupo`
if [ $? == 0 ];
then
read -p "Esta seguro que desea borrarlo? [s/n]: " opc
case $opc in
	s|S) 
	    sudo groupdel $grupo
	    if [ $? == 0 ];
	    then
	    read -p "Grupo borrado"
	    . abmc_grupos.sh
	    else
	    read -p "Hubo un error con la creacion del grupo."
	    . abmc_grupos.sh
	    fi
	    ;;
	n|N)
	    sleep 1
	    . abmc_grupos.sh
	    ;;
esac
else
read -p "Error, ese grupo no existe."
. abmc_grupos.sh
fi

