#!/bin/bash
mod_uid=0;
clear
read -p "Ingrese el nuevo numero de usuario para $usuario: " mod_uid
sudo usermod -u $mod_uid $usuario
if [ $? == 0 ];
then
read -p "UID modificado."
. modificar_usu.sh
else
read -p "Hubo un error al modificarm el UID."
. modificar_usu.sh
fi
