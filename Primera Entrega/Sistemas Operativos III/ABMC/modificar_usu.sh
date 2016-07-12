#!/bin/bash
usuario="";
function menumodif {
echo "********** MODIFICAR USUARIO **********"
echo "1) Modificar su login"
echo "2) Modificar home del usuario"
echo "3) Modificar comentario"
echo "4) Modificar su grupo"
echo "5) Modificar su shell"
echo "6) Modificar su numero"
echo "7) Bloquear usuario"
echo "8) Desbloquear usuario"
echo "9) Volver"
} 
clear
read -p "Ingrese el usuario a modificar: " usuario
busqueda=`cut -d ":" -f1 /etc/passwd | grep $usuario` 
if [ $? == 0 ];
then
menumodif
read -p "Opcion: " opc
case $opc in
	1)
	  . mod_login.sh
	  ;;
	2)
	  . mod_home.sh
	  ;;
	3)
	  . mod_comentario.sh
	  ;;
	4)
	  . mod_grupo.sh
	  ;;
	5)
	  . mod_shell.sh
	  ;;
	6)
	  . mod_uid.sh
	  ;;
	7)
	  . bloquear_usu.sh
	  ;;
	8)
	  . desbloquear_usu.sh
	  ;;
	9)
	  . abmc_usu.sh
	  ;;
esac
else
read -p "Error, ese usuario no existe."
. abmc_usu.sh 
fi
