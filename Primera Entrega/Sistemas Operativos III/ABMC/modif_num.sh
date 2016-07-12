#!/bin/bash
grupo="";
nuevonum="";
clear
read -p "Ingrese el nombre de grupo que se va a modificar: " grupo
busqueda=`cut -d ":" -f1 /etc/group | grep $grupo`
if [ $? == 0 ];
then
 read -p "Nuevo gid: " nuevonum
 verificar=`cut -d ":" -s -f3 /etc/group | grep $nuevonum`
  if [ $? == 0 ];
  then
  read -p "Ese numero de grupo ya esta en uso."
  . modificar_grupo.sh
 else
  sudo groupmod -g $nuevonum $grupo
   if [ $? == 0 ];
   then
   read -p "Numero cambiado."
   . abmc_grupos.sh
   fi
 fi
else
read -p "Error, ese grupo no existe."
. modificar_grupo.sh
fi
