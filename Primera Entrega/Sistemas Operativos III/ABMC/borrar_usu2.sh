#!/bin/bash
opc_borrar1=0;
read -p "¿Esta seguro que desea borrar el usuario $usuario y todo su contenido? [s/n]: " opc_borrar1
case $opc_borrar1 in
	s|S)
	    sudo userdel -r $usuario
	    if [ $? == 0 ];
	    then
	    read -p "Usuario borrado satisfactoriamente."
	    . abmc_usu.sh
	    else
	    read -p "Hubo un error al borrar el usuario."
	    . abmc_usu.sh
	    fi
	    ;;
	n|N)
	    . borrar_usu.sh
	    ;;
esac
