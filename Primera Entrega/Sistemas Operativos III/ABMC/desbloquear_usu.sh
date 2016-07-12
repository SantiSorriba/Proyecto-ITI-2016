#!/bin/bash
opc_desbloq="";
read -p "¿Esta seguro que desea desbloquear el usuario $usuario? [s/n]: " opc_desbloq
case $opc_desbloq in
	s|S)
	    sudo usermod -U $usuario
	    if [ $? == 0 ];
	    then
	    read -p "Usuario desbloqueado."
	    . modificar_usu.sh
	    else
	    read -p "Hubo un error al desbloquear a $usuario."
	    . modificar_usu.sh
	    fi
	    ;;
	n|N)
	    sleep 1
	    . modificar_usu.sh
	    ;;
esac
