#!/bin/bash
opc_borrar=0;
read -p "¿Esta seguro que desea borrar el usuario $usuario? [s/n]: " opc_borrar
case $opc_borrar in
	s|S)
	    sudo userdel $usuario
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
