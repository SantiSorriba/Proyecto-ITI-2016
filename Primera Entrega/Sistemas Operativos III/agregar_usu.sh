#!/bin/bash
log_usu="";
ngrupo=;
clear
echo "********** Ingresar Usuario **********"
read -p "Ingrese el login para el usuario: " log_usu
verif_usu=`cut -d ":" -f1 /etc/passwd | grep $log_usu`
if [ $? == 0 ];
then
echo "Error, ese usuario ya existe."
fi
read -p "Ingrese el numero de grupo para el usuario: " ngrupo
cut -d ":" -f3 /etc/group | grep $ngrupo
if [ $? != 0 ];
then
read -p "Error, ese grupo no existe. Verifique su grupo."
fi


