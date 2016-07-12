#!/bin/bash
log_usu="";
home_usu="";
opc_comentario="";
opc_grupo=0;
comentario="";
shell_usu="";
opc_pass="";
clear

echo "********** AGREGAR USUARIO **********"
read -p "Ingrese un nombre de login para el usuario: " log_usu
existe=`cut -d ":" -f1 /etc/passwd | grep $log_usu`
if [ $? == 0 ];
then
read -p "Error, ese usuario ya existe."
. abmc_usu.sh
else
read -p "Ingrese el home para $log_usu: " home_usu
read -p "¿Desea ingresar un comentario? [s/n]" opc_comentario
case $opc_comentario in
	s|S) 
	    read -p "Comentario: " comentario
	    ;;
	n|N)
	    sleep 1
	    ;;
esac
. grupos_usu.sh
read -p "Ingrese la shell que va a utilizar el usuario: " shell_usu
echo "Ingresando usuario..."
sleep 2
if [ -z "$comentario" ];
then
sudo useradd -d $home_usu -mk /etc/skel -g $grupo_usu -s $shell_usu $log_usu
else
sudo useradd -d $home_usu -mk /etc/skel -c $comentario -g $grupo_usu -s $shell_usu $log_usu
fi
 if [ $? == 0 ];
 then
  read -p "¿Desea que $log_usu tenga contraseña? [s/n]" opc_pass
  case $opc_pass in
  	s|S)
	    sudo passwd $log_usu
	    read -p "Presione enter para volver..."
	    . abmc_usu.sh
	    ;;
	n|N)	
  	    read -p "Usuario ingresado satisfactoriamente."
	    . abmc_usu.sh
	    ;; 
  esac
  else
  read -p "Hubo un error al ingresar el usuario. Verifique cuidadosamente los datos ingresados."
  . abmc_usu.sh
 fi
fi
