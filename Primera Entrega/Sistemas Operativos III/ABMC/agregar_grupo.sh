#!/bin/bash
grupo="";
opc="";
gid=0;
clear
echo "********** AGREGAR GRUPO **********"
read -p "Ingrese el nombre del grupo: " grupo
busqueda=`cut -d ":" -f1 /etc/group | grep $grupo`
if [ $? == 0 ];
then
read -p "Error, ese grupo ya existe."
. abmc_grupos.sh
else
read -p "Desea establecerle un numero de grupo a $grupo? [s/n]: " opc
case $opc in
	s|S)
	    read -p "GID: " gid
	    verificar=`cut -d ":" -s -f3 /etc/group | grep $gid`
	    if [ $? == 0 ];
	    then
	    read -p "Ese gid ya esta en uso. "
	    else
	    sudo groupadd -g $gid $grupo
	    if [ $? == 0 ];
	    then
	    read -p "Grupo agregado"
	    . abmc_grupos.sh
	    else
	    read -p "Hubo un error con la creacion del grupo."
	    . abmc_grupos.sh
	    fi
	    fi
	    ;;
	n|N)
	    sudo groupadd $grupo
	    if [ $? == 0 ];
	    then
	    read -p "Grupo agregado"
	    . abmc_grupos.sh
	    else
	    read -p "Hubo un error con la creacion del grupo."
	    . abmc_grupos.sh
	    fi
	    ;;
esac
fi
