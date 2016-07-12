#!/bin/bash
opc_bloq="";
read -p "¿Esta seguro que desea bloquear el usuario $usuario? [s/n]: " opc_bloq
case $opc_bloq in
	s|S)
	    sudo usermod -L $usuario
	    if [ $? == 0 ];
	    then
	    read -p "Usuario bloqueado."
	    . modificar_usu.sh
	    else
	    read -p "Hubo un error al bloquear a $usuario."
	    . modificar_usu.sh
	    fi
	    ;;
	n|N)
	    sleep 1
	    . modificar_usu.sh
	    ;;
esac
