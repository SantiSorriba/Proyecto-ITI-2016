#!/bin/bash
mod_comentario="";
clear
read -p "Ingrese el nuevo comentario para el usuario: " mod_comentario
sudo usermod -c $mod_comentario $usuario
if [ $? == 0 ];
then
read -p "Comentario modificado."
. modificar_usu.sh
else
read -p "Hubo un error con la modificacion del comentario."
. modificar_usu.sh
fi
