#!/bin/bash
mod_shell="";
clear
read -p "Ingrese la nueva shell para el usuario: " mod_shell
sudo usermod -s $mod_shell $usuario
if [ $? == 0 ];
then
read -p "Shell modificada correctamente."
. modificar_usu.sh
else
read -p "Hubo un error en la modificacion del shell."
. modificar_usu.sh
fi
