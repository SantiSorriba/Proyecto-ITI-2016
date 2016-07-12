#!/bin/bash
mod_gid=0;
clear
read -p "Ingrese el nuevo numero de grupo para el usuario: " mod_gid
busqueda=`cut -d ":" -s -f3 /etc/group | grep $mod_gid`
if [ $? == 0 ];
then
sudo usermod -g $mod_gid $usuario
if [ $? == 0 ];
then
read -p "GID Modificado correctamente."
. modificar_usu.sh
else
read -p "Hubo un error con la modificacion del GID."
. modificar_usu.sh
fi
else
read -p "Error, ese grupo no existe."
. modificar_usu.sh
fi
