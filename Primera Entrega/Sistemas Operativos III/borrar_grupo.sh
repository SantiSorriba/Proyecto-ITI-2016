#!/bin/bash
grupo="";
clear
echo "********** Borrar Grupo **********"
read -p "Ingrese el nombre del grupo a borrar: " grupo
sudo groupdel $grupo
if [ $? == 0 ];
then
read -p "Grupo borrado satisfactoriamente."
fi

