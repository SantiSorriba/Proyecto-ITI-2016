#!/bin/bash
usuario="";
opc=0;
log="";
function menumodif {
echo "1) Modificar su login"
echo "2) Modificar home del usuario"
echo "3) Modificar comentario"
echo "4) Modificar su grupo"
echo "5) Modificar su shell"
echo "6) Modificar su numero"
echo "7) Bloquear usuario"
echo "8) Desbloquear usuario" 
}
clear
echo "********** Modificar Usuario **********"
read -p "Ingrese el usuario a modificar: " usuario
busqueda=`cut -d ":" -f1 /etc/passwd | grep $usuario` 
if [ $? == 0 ];
then
menumodif
read -p "Opcion: " opc
case $opc in
	1)
	  read -p "Ingrese el nuevo login para el usuario: " log
	  verif=`cut -d ":" -f1 /etc/passwd | grep $log`
	  if [ $? == 0 ];
	  then
	   read -p "Error, ese login ya esta en uso por otro usuario."
	  else
	   sudo usermod -l $log $usuario
	   if [ $? == 0 ];
	   then
	    read -p "Login modificado."
	   else
	    read -p "Hubo un error en la modificacion del usuario."
	   fi
	  fi
	  ;;
	2)
	  homeactual=`cut -d ":" -s -f6 /etc/passwd | grep $usuario`
	  echo "Home actual de $usuario: " $homeactual
	  read -p "Ingrese nuevo home para el usuario: " home
	  verif=`cut -d ":" -s -f6 /etc/passwd | grep $home`
	  if [ $? == 0 ];
	   then
	    read -p "Error, ese home ya esta en uso."
	   else
	    sudo usermod -d $home $usuario
	    if [ $? == 0 ];
	    then
	    read -p "Home modificado."
	   else
	    read -p "Hubo un error en la modificacion del usuario."
	   fi
	  fi
	  ;;
	3)
	  ;;
	4)
	  ;;
	5)
	  ;;
	6)
	  ;;
	7)
	  ;;
	8)
	  ;;
	*)
	  read -p "Error, verifique su opcion."
	  ;;
 esac
else
read -p "Ese usuario no existe. Presione enter para continuar..."
fi
