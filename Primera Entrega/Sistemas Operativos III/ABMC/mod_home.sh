#!/bin/bash
mod_home="";
clear
read -p "Ingrese el nuevo home para el usuario: " mod_home
verificar=`cut -d ":" -s -f6 /etc/passwd | grep $mod_home`
if [ $? == 0 ];
then
read -p "Error, ese home ya esta en uso para otro usuario."
menumodif
else
sudo usermod -d $mod_home $usuario
 if [ $? == 0 ];
 then
 read -p "Home modificado."
 else
 read -p "Hubo un error en la modificacion del usuario."
 . modificar_usu.sh
 fi
fi
