#!/bin/bash
mod_log="";
clear
read -p "Ingrese el nuevo login para el usuario: " mod_log
verificar=`cut -d ":" -f1 /etc/passwd | grep $mod_log`
if [ $? == 0 ];
then
read -p "Error, ese login ya esta en uso por otro usuario."
. modificar_usu.sh
else
sudo usermod -l $mod_log $usuario
 if [ $? == 0 ];
 then
 read -p "Login modificado."
 else
 read -p "Hubo un error en la modificacion del usuario."
 . modificar_usu.sh
 fi
fi
	  
