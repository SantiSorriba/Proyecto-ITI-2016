#!/bin/bash
echo "***** Grupos Opcionales *****"
echo "1) Administrador del sistema"
echo "2) Gerente administrador"
echo "3) Administrador de un establecimiento"
echo "4) Auxiliar"
echo "5) Otro"
read -p "Opcion: " opc_grupo
case $opc_grupo in
	1)
	  grupo_usu=2050;
	  ;;
	2)
	  grupo_usu=2051;
	  ;;
	3)
	  grupo_usu=2052;
	  ;;
	4)
	  grupo_usu=2053;
	  ;;
	5)
	  read -p "Ingrese el numero de grupo: " grupo_usu
	  ;;
esac
