{ DATABASE binasoft  delimiter | }

grant dba to "ssorriba";
grant dba to "fiza";
grant dba to "jbarzi";
grant dba to "pmachin";
grant dba to "ipacheco";
grant dba to "bs_adm_sis1";










 


 

{ TABLE "ssorriba".cooperativa row size = 82 number of columns = 6 index size = 9 
              }
{ unload file name = coope00100.unl number of rows = 1 }

create table "ssorriba".cooperativa 
  (
    nro_bps integer not null ,
    nro_rut integer not null ,
    departamento char(15) not null ,
    nombre char(30) not null ,
    direccion char(25) not null ,
    telefono integer not null ,
    primary key (nro_bps)  constraint "ssorriba".pkcooperativa
  );
revoke all on "ssorriba".cooperativa from "public";

{ TABLE "jbarzi".tipos_de_servicio row size = 19 number of columns = 2 index size 
              = 9 }
{ unload file name = tipos00101.unl number of rows = 6 }

create table "jbarzi".tipos_de_servicio 
  (
    id_servicio integer not null ,
    tipo char(15) not null ,
    primary key (id_servicio)  constraint "jbarzi".pktiposdeservicio
  );
revoke all on "jbarzi".tipos_de_servicio from "public";

{ TABLE "jbarzi".muerte row size = 19 number of columns = 2 index size = 9 }
{ unload file name = muert00102.unl number of rows = 0 }

create table "jbarzi".muerte 
  (
    nro_evento integer not null ,
    causa char(15) not null ,
    primary key (nro_evento)  constraint "jbarzi".pkmuerte
  );
revoke all on "jbarzi".muerte from "public";

{ TABLE "fiza".telefonos_propietario row size = 8 number of columns = 2 index size 
              = 22 }
{ unload file name = telef00103.unl number of rows = 2 }

create table "fiza".telefonos_propietario 
  (
    ci integer not null ,
    telefono integer not null ,
    primary key (ci,telefono)  constraint "fiza".pktel
  );
revoke all on "fiza".telefonos_propietario from "public";

{ TABLE "ssorriba".establecimientos row size = 94 number of columns = 9 index size 
              = 27 }
{ unload file name = estab00104.unl number of rows = 5 }

create table "ssorriba".establecimientos 
  (
    nro_dicose integer not null ,
    nro_rut integer not null ,
    nro_bps integer not null ,
    nombre char(30) not null ,
    direccion char(25) not null ,
    departamento char(15) not null ,
    superficie integer not null ,
    limite_animales integer not null ,
    ci_propietario integer not null ,
    primary key (nro_dicose)  constraint "ssorriba".pkestablecimientos
  );
revoke all on "ssorriba".establecimientos from "public";

{ TABLE "ssorriba".telefonos_establecimiento row size = 8 number of columns = 2 index 
              size = 22 }
{ unload file name = telef00105.unl number of rows = 2 }

create table "ssorriba".telefonos_establecimiento 
  (
    nro_dicose integer not null ,
    telefono integer not null ,
    primary key (nro_dicose,telefono)  constraint "ssorriba".pktelestablecimientos
  );
revoke all on "ssorriba".telefonos_establecimiento from "public";

{ TABLE "jbarzi".animales row size = 72 number of columns = 8 index size = 27 }
{ unload file name = anima00106.unl number of rows = 157 }

create table "jbarzi".animales 
  (
    nro_identificador integer not null ,
    id_animal integer not null ,
    nombre char(15) not null ,
    raza char(15) not null ,
    sexo char(6) not null ,
    fecha_nac date not null ,
    lugar_actual char(20) not null ,
    nro_dicose integer not null ,
    primary key (nro_identificador)  constraint "jbarzi".pkanimales
  );
revoke all on "jbarzi".animales from "public";

{ TABLE "fiza".eventos row size = 16 number of columns = 4 index size = 27 }
{ unload file name = event00107.unl number of rows = 0 }

create table "fiza".eventos 
  (
    nro_evento integer not null ,
    nro_animal integer not null ,
    fecha date not null ,
    id_evento integer not null ,
    primary key (nro_evento)  constraint "fiza".pk2
  );
revoke all on "fiza".eventos from "public";

{ TABLE "ssorriba".usuarios row size = 97 number of columns = 8 index size = 27 }
{ unload file name = usuar00108.unl number of rows = 4 }

create table "ssorriba".usuarios 
  (
    ci integer not null ,
    id integer not null ,
    nombre char(15) not null ,
    apellido char(15) not null ,
    direccion char(25) not null ,
    departamento char(15) not null ,
    nombre_usu char(15) not null ,
    nro_bps integer not null ,
    primary key (ci)  constraint "ssorriba".pkusuarios
  );
revoke all on "ssorriba".usuarios from "public";

{ TABLE "jbarzi".tipos_de_animales row size = 29 number of columns = 2 index size 
              = 9 }
{ unload file name = tipos00109.unl number of rows = 4 }

create table "jbarzi".tipos_de_animales 
  (
    id_animal integer not null ,
    tipo char(25) not null ,
    primary key (id_animal)  constraint "jbarzi".pktiposdeanimales
  );
revoke all on "jbarzi".tipos_de_animales from "public";

{ TABLE "fiza".tipos_de_eventos row size = 19 number of columns = 2 index size = 
              9 }
{ unload file name = tipos00110.unl number of rows = 5 }

create table "fiza".tipos_de_eventos 
  (
    id_evento integer not null ,
    tipo char(15) not null ,
    primary key (id_evento)  constraint "fiza".pk7
  );
revoke all on "fiza".tipos_de_eventos from "public";

{ TABLE "ssorriba".tipos_de_usuario row size = 44 number of columns = 2 index size 
              = 9 }
{ unload file name = tipos00111.unl number of rows = 4 }

create table "ssorriba".tipos_de_usuario 
  (
    id integer not null ,
    tipo char(40) not null ,
    primary key (id)  constraint "ssorriba".pktiposusuarios
  );
revoke all on "ssorriba".tipos_de_usuario from "public";

{ TABLE "ssorriba".telefonos_usuario row size = 8 number of columns = 2 index size 
              = 22 }
{ unload file name = telef00112.unl number of rows = 3 }

create table "ssorriba".telefonos_usuario 
  (
    ci integer not null ,
    telefono integer not null ,
    primary key (ci,telefono)  constraint "ssorriba".pktelusuarios
  );
revoke all on "ssorriba".telefonos_usuario from "public";

{ TABLE "fiza".vendido row size = 4 number of columns = 1 index size = 9 }
{ unload file name = vendi00113.unl number of rows = 0 }

create table "fiza".vendido 
  (
    nro_evento integer not null ,
    primary key (nro_evento)  constraint "fiza".pkvendido
  );
revoke all on "fiza".vendido from "public";

{ TABLE "jbarzi".animales_no_productivos row size = 19 number of columns = 2 index 
              size = 9 }
{ unload file name = anima00114.unl number of rows = 6 }

create table "jbarzi".animales_no_productivos 
  (
    nro_identificador integer not null ,
    tipo char(15) not null ,
    primary key (nro_identificador)  constraint "jbarzi".pkanimalesnoproductivos
  );
revoke all on "jbarzi".animales_no_productivos from "public";

{ TABLE "jbarzi".toro row size = 4 number of columns = 1 index size = 9 }
{ unload file name = toro_00115.unl number of rows = 4 }

create table "jbarzi".toro 
  (
    nro_identificador integer not null ,
    primary key (nro_identificador)  constraint "jbarzi".pktoro
  );
revoke all on "jbarzi".toro from "public";

{ TABLE "ssorriba".propietario row size = 74 number of columns = 5 index size = 9 
              }
{ unload file name = propi00116.unl number of rows = 5 }

create table "ssorriba".propietario 
  (
    ci integer not null ,
    nombre char(15) not null ,
    apellido char(15) not null ,
    departamento char(15) not null ,
    direccion char(25) not null ,
    primary key (ci)  constraint "ssorriba".pkpropietario
  );
revoke all on "ssorriba".propietario from "public";

{ TABLE "jbarzi".vaca row size = 4 number of columns = 1 index size = 9 }
{ unload file name = vaca_00117.unl number of rows = 126 }

create table "jbarzi".vaca 
  (
    nro_identificador integer not null ,
    primary key (nro_identificador)  constraint "jbarzi".pkvaca
  );
revoke all on "jbarzi".vaca from "public";

{ TABLE "fiza".enfermedad row size = 34 number of columns = 3 index size = 9 }
{ unload file name = enfer00118.unl number of rows = 0 }

create table "fiza".enfermedad 
  (
    nro_evento integer not null ,
    nombre char(15),
    medicamento char(15),
    primary key (nro_evento)  constraint "fiza".pk1
  );
revoke all on "fiza".enfermedad from "public";

{ TABLE "ipacheco".cria row size = 4 number of columns = 1 index size = 9 }
{ unload file name = cria_00119.unl number of rows = 21 }

create table "ipacheco".cria 
  (
    nro_identificador integer not null ,
    primary key (nro_identificador)  constraint "ipacheco".pkcria
  );
revoke all on "ipacheco".cria from "public";

{ TABLE "fiza".parto row size = 4 number of columns = 1 index size = 9 }
{ unload file name = parto00120.unl number of rows = 0 }

create table "fiza".parto 
  (
    nro_evento integer not null ,
    primary key (nro_evento)  constraint "fiza".pk3
  );
revoke all on "fiza".parto from "public";

{ TABLE "ipacheco".campo_de_recria row size = 18 number of columns = 3 index size 
              = 18 }
{ unload file name = campo00121.unl number of rows = 0 }

create table "ipacheco".campo_de_recria 
  (
    nro_animal integer not null ,
    nro_establecimiento integer not null ,
    peso decimal(16) not null ,
    primary key (nro_animal)  constraint "ipacheco".pkcamporecria
  );
revoke all on "ipacheco".campo_de_recria from "public";

{ TABLE "ipacheco".lotes row size = 48 number of columns = 4 index size = 9 }
{ unload file name = lotes00122.unl number of rows = 3 }

create table "ipacheco".lotes 
  (
    nro_lote integer not null ,
    nombre char(20) not null ,
    cant_animales integer not null ,
    criterio char(20) not null ,
    primary key (nro_lote)  constraint "ipacheco".pklotes
  );
revoke all on "ipacheco".lotes from "public";

{ TABLE "ipacheco".leche row size = 24 number of columns = 2 index size = 9 }
{ unload file name = leche00123.unl number of rows = 3 }

create table "ipacheco".leche 
  (
    tipo integer not null ,
    descripcion char(20) not null ,
    primary key (tipo)  constraint "ipacheco".pkleche
  );
revoke all on "ipacheco".leche from "public";

{ TABLE "fiza".servicio row size = 8 number of columns = 2 index size = 18 }
{ unload file name = servi00124.unl number of rows = 0 }

create table "fiza".servicio 
  (
    nro_evento integer not null ,
    id_servicio integer not null ,
    primary key (nro_evento)  constraint "fiza".pk5
  );
revoke all on "fiza".servicio from "public";

{ TABLE "fiza".convertido row size = 8 number of columns = 2 index size = 9 }
{ unload file name = conve00125.unl number of rows = 0 }

create table "fiza".convertido 
  (
    nro_identificador integer not null ,
    fecha date not null ,
    primary key (nro_identificador)  constraint "fiza".pk
  );
revoke all on "fiza".convertido from "public";

{ TABLE "jbarzi".separadas_en row size = 28 number of columns = 3 index size = 18 
              }
{ unload file name = separ00126.unl number of rows = 0 }

create table "jbarzi".separadas_en 
  (
    nro_identificador integer not null ,
    estado_vaca char(20) not null ,
    nro_lote integer not null ,
    primary key (nro_identificador)  constraint "jbarzi".pkseparadasen
  );
revoke all on "jbarzi".separadas_en from "public";

{ TABLE "ssorriba".producen row size = 28 number of columns = 7 index size = 31 }
{ unload file name = produ00127.unl number of rows = 2 }

create table "ssorriba".producen 
  (
    tipo integer not null ,
    nro_lote integer not null ,
    fecha date not null ,
    primer_ordenie integer not null ,
    segundo_ordenie integer not null ,
    tercer_ordenie integer not null ,
    cant_producida integer not null ,
    primary key (fecha,nro_lote)  constraint "ssorriba".pkproducen
  );
revoke all on "ssorriba".producen from "public";

{ TABLE "jbarzi".se_dirige row size = 8 number of columns = 2 index size = 9 }
{ unload file name = se_di00128.unl number of rows = 0 }

create table "jbarzi".se_dirige 
  (
    nro_identificador integer not null ,
    fecha date not null ,
    primary key (nro_identificador)  constraint "jbarzi".pksedirige
  );
revoke all on "jbarzi".se_dirige from "public";

{ TABLE "fiza".se_convierte row size = 8 number of columns = 2 index size = 9 }
{ unload file name = se_co00129.unl number of rows = 0 }

create table "fiza".se_convierte 
  (
    nro_identificador integer not null ,
    fecha date not null ,
    primary key (nro_identificador)  constraint "fiza".pk4
  );
revoke all on "fiza".se_convierte from "public";

{ TABLE "pmachin".compuesta_por row size = 8 number of columns = 2 index size = 18 
              }
{ unload file name = compu00130.unl number of rows = 5 }

create table "pmachin".compuesta_por 
  (
    nro_bps integer not null ,
    nro_dicose integer not null ,
    primary key (nro_dicose)  constraint "pmachin".pkcompuestapor
  );
revoke all on "pmachin".compuesta_por from "public";

{ TABLE "pmachin".le_pertenece row size = 8 number of columns = 2 index size = 18 
              }
{ unload file name = le_pe00131.unl number of rows = 5 }

create table "pmachin".le_pertenece 
  (
    nro_dicose integer not null ,
    ci integer not null ,
    primary key (nro_dicose)  constraint "pmachin".pklepertenece
  );
revoke all on "pmachin".le_pertenece from "public";

{ TABLE "pmachin".cuentan_con row size = 8 number of columns = 2 index size = 18 
              }
{ unload file name = cuent00132.unl number of rows = 0 }

create table "pmachin".cuentan_con 
  (
    nro_dicose integer not null ,
    nro_animal integer not null ,
    primary key (nro_dicose)  constraint "pmachin".pkcuentancon
  );
revoke all on "pmachin".cuentan_con from "public";

{ TABLE "pmachin".protagonizan row size = 8 number of columns = 2 index size = 31 
              }
{ unload file name = prota00133.unl number of rows = 0 }

create table "pmachin".protagonizan 
  (
    nro_identificador integer not null ,
    nro_evento integer not null ,
    primary key (nro_identificador,nro_evento)  constraint "pmachin".pkprotagonizan
  );
revoke all on "pmachin".protagonizan from "public";

{ TABLE "pmachin".entore row size = 12 number of columns = 3 index size = 31 }
{ unload file name = entor00134.unl number of rows = 0 }

create table "pmachin".entore 
  (
    nro_identificador_toro integer not null ,
    nro_identificador_vaca integer not null ,
    fecha_entore date not null ,
    primary key (nro_identificador_toro,nro_identificador_vaca)  constraint "pmachin".pkentore
  );
revoke all on "pmachin".entore from "public";

{ TABLE "pmachin".tienen row size = 12 number of columns = 3 index size = 39 }
{ unload file name = tiene00135.unl number of rows = 0 }

create table "pmachin".tienen 
  (
    nro_identificador_toro integer not null ,
    nro_identificador_vaca integer not null ,
    nro_identificador_cria integer not null ,
    primary key (nro_identificador_toro,nro_identificador_vaca,nro_identificador_cria) 
               constraint "pmachin".pktienen
  );
revoke all on "pmachin".tienen from "public";

{ TABLE "pmachin".salen row size = 28 number of columns = 3 index size = 9 }
{ unload file name = salen00136.unl number of rows = 0 }

create table "pmachin".salen 
  (
    nro_identificador integer not null ,
    fecha date not null ,
    tipo char(20) not null ,
    primary key (nro_identificador)  constraint "pmachin".pksalen
  );
revoke all on "pmachin".salen from "public";


grant select on "ssorriba".cooperativa to "bs_adm_est2" as "ssorriba";
grant select on "ssorriba".cooperativa to "bs_aux1" as "ssorriba";
grant select on "ssorriba".cooperativa to "bs_adm_est1" as "ssorriba";
grant select on "ssorriba".cooperativa to "bs_aux2" as "ssorriba";
grant select on "ssorriba".cooperativa to "public" as "ssorriba";
grant update on "ssorriba".cooperativa to "public" as "ssorriba";
grant insert on "ssorriba".cooperativa to "public" as "ssorriba";
grant delete on "ssorriba".cooperativa to "public" as "ssorriba";
grant index on "ssorriba".cooperativa to "public" as "ssorriba";
grant select on "ssorriba".cooperativa to "bs_gerente1" as "ssorriba";
grant select on "ssorriba".cooperativa to "bs_gerente2" as "ssorriba";
grant select on "jbarzi".tipos_de_servicio to "bs_adm_est2" as "jbarzi";
grant select on "jbarzi".tipos_de_servicio to "bs_aux1" as "jbarzi";
grant select on "jbarzi".tipos_de_servicio to "bs_aux2" as "jbarzi";
grant select on "jbarzi".tipos_de_servicio to "bs_gerente1" as "jbarzi";
grant select on "jbarzi".tipos_de_servicio to "bs_gerente2" as "jbarzi";
grant select on "jbarzi".tipos_de_servicio to "bs_adm_est1" as "jbarzi";
grant select on "jbarzi".tipos_de_servicio to "public" as "jbarzi";
grant update on "jbarzi".tipos_de_servicio to "public" as "jbarzi";
grant insert on "jbarzi".tipos_de_servicio to "public" as "jbarzi";
grant delete on "jbarzi".tipos_de_servicio to "public" as "jbarzi";
grant index on "jbarzi".tipos_de_servicio to "public" as "jbarzi";
grant select on "jbarzi".muerte to "bs_adm_est2" as "jbarzi";
grant select on "jbarzi".muerte to "bs_aux1" as "jbarzi";
grant update on "jbarzi".muerte to "bs_aux1" as "jbarzi";
grant insert on "jbarzi".muerte to "bs_aux1" as "jbarzi";
grant select on "jbarzi".muerte to "bs_aux2" as "jbarzi";
grant update on "jbarzi".muerte to "bs_aux2" as "jbarzi";
grant insert on "jbarzi".muerte to "bs_aux2" as "jbarzi";
grant select on "jbarzi".muerte to "bs_gerente1" as "jbarzi";
grant select on "jbarzi".muerte to "bs_gerente2" as "jbarzi";
grant select on "jbarzi".muerte to "bs__adm_est1" as "jbarzi";
grant select on "jbarzi".muerte to "public" as "jbarzi";
grant update on "jbarzi".muerte to "public" as "jbarzi";
grant insert on "jbarzi".muerte to "public" as "jbarzi";
grant delete on "jbarzi".muerte to "public" as "jbarzi";
grant index on "jbarzi".muerte to "public" as "jbarzi";
grant select on "fiza".telefonos_propietario to "bs_adm_est2" as "fiza";
grant update on "fiza".telefonos_propietario to "bs_adm_est2" as "fiza";
grant insert on "fiza".telefonos_propietario to "bs_adm_est2" as "fiza";
grant delete on "fiza".telefonos_propietario to "bs_adm_est2" as "fiza";
grant select on "fiza".telefonos_propietario to "bs_aux1" as "fiza";
grant update on "fiza".telefonos_propietario to "bs_aux1" as "fiza";
grant insert on "fiza".telefonos_propietario to "bs_aux1" as "fiza";
grant delete on "fiza".telefonos_propietario to "bs_aux1" as "fiza";
grant select on "fiza".telefonos_propietario to "bs_adm_est1" as "fiza";
grant update on "fiza".telefonos_propietario to "bs_adm_est1" as "fiza";
grant insert on "fiza".telefonos_propietario to "bs_adm_est1" as "fiza";
grant delete on "fiza".telefonos_propietario to "bs_adm_est1" as "fiza";
grant select on "fiza".telefonos_propietario to "bs_aux2" as "fiza";
grant update on "fiza".telefonos_propietario to "bs_aux2" as "fiza";
grant insert on "fiza".telefonos_propietario to "bs_aux2" as "fiza";
grant delete on "fiza".telefonos_propietario to "bs_aux2" as "fiza";
grant select on "fiza".telefonos_propietario to "public" as "fiza";
grant update on "fiza".telefonos_propietario to "public" as "fiza";
grant insert on "fiza".telefonos_propietario to "public" as "fiza";
grant delete on "fiza".telefonos_propietario to "public" as "fiza";
grant index on "fiza".telefonos_propietario to "public" as "fiza";
grant select on "fiza".telefonos_propietario to "bs_gerente1" as "fiza";
grant select on "fiza".telefonos_propietario to "bs_gerente2" as "fiza";
grant select on "ssorriba".establecimientos to "bs_adm_est1" as "ssorriba";
grant update on "ssorriba".establecimientos to "bs_adm_est1" as "ssorriba";
grant insert on "ssorriba".establecimientos to "bs_adm_est1" as "ssorriba";
grant select on "ssorriba".establecimientos to "public" as "ssorriba";
grant update on "ssorriba".establecimientos to "public" as "ssorriba";
grant insert on "ssorriba".establecimientos to "public" as "ssorriba";
grant delete on "ssorriba".establecimientos to "public" as "ssorriba";
grant index on "ssorriba".establecimientos to "public" as "ssorriba";
grant select on "ssorriba".establecimientos to "bs_adm_est2" as "ssorriba";
grant update on "ssorriba".establecimientos to "bs_adm_est2" as "ssorriba";
grant insert on "ssorriba".establecimientos to "bs_adm_est2" as "ssorriba";
grant select on "ssorriba".establecimientos to "bs_aux1" as "ssorriba";
grant update on "ssorriba".establecimientos to "bs_aux1" as "ssorriba";
grant insert on "ssorriba".establecimientos to "bs_aux1" as "ssorriba";
grant delete on "ssorriba".establecimientos to "bs_aux1" as "ssorriba";
grant select on "ssorriba".establecimientos to "bs_aux2" as "ssorriba";
grant update on "ssorriba".establecimientos to "bs_aux2" as "ssorriba";
grant insert on "ssorriba".establecimientos to "bs_aux2" as "ssorriba";
grant delete on "ssorriba".establecimientos to "bs_aux2" as "ssorriba";
grant select on "ssorriba".establecimientos to "bs_gerente1" as "ssorriba";
grant select on "ssorriba".establecimientos to "bs_gerente2" as "ssorriba";
grant select on "ssorriba".telefonos_establecimiento to "bs_adm_est2" as "ssorriba";
grant update on "ssorriba".telefonos_establecimiento to "bs_adm_est2" as "ssorriba";
grant insert on "ssorriba".telefonos_establecimiento to "bs_adm_est2" as "ssorriba";
grant delete on "ssorriba".telefonos_establecimiento to "bs_adm_est2" as "ssorriba";
grant select on "ssorriba".telefonos_establecimiento to "bs_aux1" as "ssorriba";
grant update on "ssorriba".telefonos_establecimiento to "bs_aux1" as "ssorriba";
grant insert on "ssorriba".telefonos_establecimiento to "bs_aux1" as "ssorriba";
grant delete on "ssorriba".telefonos_establecimiento to "bs_aux1" as "ssorriba";
grant select on "ssorriba".telefonos_establecimiento to "bs_adm_est1" as "ssorriba";
grant update on "ssorriba".telefonos_establecimiento to "bs_adm_est1" as "ssorriba";
grant insert on "ssorriba".telefonos_establecimiento to "bs_adm_est1" as "ssorriba";
grant delete on "ssorriba".telefonos_establecimiento to "bs_adm_est1" as "ssorriba";
grant select on "ssorriba".telefonos_establecimiento to "bs_aux2" as "ssorriba";
grant update on "ssorriba".telefonos_establecimiento to "bs_aux2" as "ssorriba";
grant insert on "ssorriba".telefonos_establecimiento to "bs_aux2" as "ssorriba";
grant delete on "ssorriba".telefonos_establecimiento to "bs_aux2" as "ssorriba";
grant select on "ssorriba".telefonos_establecimiento to "public" as "ssorriba";
grant update on "ssorriba".telefonos_establecimiento to "public" as "ssorriba";
grant insert on "ssorriba".telefonos_establecimiento to "public" as "ssorriba";
grant delete on "ssorriba".telefonos_establecimiento to "public" as "ssorriba";
grant index on "ssorriba".telefonos_establecimiento to "public" as "ssorriba";
grant select on "ssorriba".telefonos_establecimiento to "bs_gerente1" as "ssorriba";
grant select on "ssorriba".telefonos_establecimiento to "bs_gerente2" as "ssorriba";
grant select on "jbarzi".animales to "bs_adm_est2" as "jbarzi";
grant select on "jbarzi".animales to "bs_aux1" as "jbarzi";
grant update on "jbarzi".animales to "bs_aux1" as "jbarzi";
grant insert on "jbarzi".animales to "bs_aux1" as "jbarzi";
grant delete on "jbarzi".animales to "bs_aux1" as "jbarzi";
grant select on "jbarzi".animales to "bs_adm_est1" as "jbarzi";
grant select on "jbarzi".animales to "bs_aux2" as "jbarzi";
grant update on "jbarzi".animales to "bs_aux2" as "jbarzi";
grant insert on "jbarzi".animales to "bs_aux2" as "jbarzi";
grant delete on "jbarzi".animales to "bs_aux2" as "jbarzi";
grant select on "jbarzi".animales to "public" as "jbarzi";
grant update on "jbarzi".animales to "public" as "jbarzi";
grant insert on "jbarzi".animales to "public" as "jbarzi";
grant delete on "jbarzi".animales to "public" as "jbarzi";
grant index on "jbarzi".animales to "public" as "jbarzi";
grant select on "jbarzi".animales to "bs_gerente1" as "jbarzi";
grant select on "jbarzi".animales to "bs_gerente2" as "jbarzi";
grant select on "fiza".eventos to "bs_adm_est2" as "fiza";
grant select on "fiza".eventos to "bs_aux1" as "fiza";
grant update on "fiza".eventos to "bs_aux1" as "fiza";
grant insert on "fiza".eventos to "bs_aux1" as "fiza";
grant select on "fiza".eventos to "bs_adm_est1" as "fiza";
grant select on "fiza".eventos to "bs_aux2" as "fiza";
grant update on "fiza".eventos to "bs_aux2" as "fiza";
grant insert on "fiza".eventos to "bs_aux2" as "fiza";
grant select on "fiza".eventos to "public" as "fiza";
grant update on "fiza".eventos to "public" as "fiza";
grant insert on "fiza".eventos to "public" as "fiza";
grant delete on "fiza".eventos to "public" as "fiza";
grant index on "fiza".eventos to "public" as "fiza";
grant select on "fiza".eventos to "bs_gerente1" as "fiza";
grant select on "fiza".eventos to "bs_gerente2" as "fiza";
grant select on "ssorriba".usuarios to "public" as "ssorriba";
grant update on "ssorriba".usuarios to "public" as "ssorriba";
grant insert on "ssorriba".usuarios to "public" as "ssorriba";
grant delete on "ssorriba".usuarios to "public" as "ssorriba";
grant index on "ssorriba".usuarios to "public" as "ssorriba";
grant select on "jbarzi".tipos_de_animales to "bs_adm_est1" as "jbarzi";
grant select on "jbarzi".tipos_de_animales to "public" as "jbarzi";
grant update on "jbarzi".tipos_de_animales to "public" as "jbarzi";
grant insert on "jbarzi".tipos_de_animales to "public" as "jbarzi";
grant delete on "jbarzi".tipos_de_animales to "public" as "jbarzi";
grant index on "jbarzi".tipos_de_animales to "public" as "jbarzi";
grant select on "jbarzi".tipos_de_animales to "bs_adm_est2" as "jbarzi";
grant select on "jbarzi".tipos_de_animales to "bs_aux1" as "jbarzi";
grant select on "jbarzi".tipos_de_animales to "bs_aux2" as "jbarzi";
grant select on "jbarzi".tipos_de_animales to "bs_gerente1" as "jbarzi";
grant select on "jbarzi".tipos_de_animales to "bs_gerente2" as "jbarzi";
grant select on "fiza".tipos_de_eventos to "bs_adm_est2" as "fiza";
grant select on "fiza".tipos_de_eventos to "bs_aux1" as "fiza";
grant select on "fiza".tipos_de_eventos to "bs_aux2" as "fiza";
grant select on "fiza".tipos_de_eventos to "bs_adm_est1" as "fiza";
grant select on "fiza".tipos_de_eventos to "bs_gerente1" as "fiza";
grant select on "fiza".tipos_de_eventos to "public" as "fiza";
grant update on "fiza".tipos_de_eventos to "public" as "fiza";
grant insert on "fiza".tipos_de_eventos to "public" as "fiza";
grant delete on "fiza".tipos_de_eventos to "public" as "fiza";
grant index on "fiza".tipos_de_eventos to "public" as "fiza";
grant select on "fiza".tipos_de_eventos to "bs_gerente2" as "fiza";
grant select on "ssorriba".tipos_de_usuario to "public" as "ssorriba";
grant update on "ssorriba".tipos_de_usuario to "public" as "ssorriba";
grant insert on "ssorriba".tipos_de_usuario to "public" as "ssorriba";
grant delete on "ssorriba".tipos_de_usuario to "public" as "ssorriba";
grant index on "ssorriba".tipos_de_usuario to "public" as "ssorriba";
grant select on "ssorriba".telefonos_usuario to "public" as "ssorriba";
grant update on "ssorriba".telefonos_usuario to "public" as "ssorriba";
grant insert on "ssorriba".telefonos_usuario to "public" as "ssorriba";
grant delete on "ssorriba".telefonos_usuario to "public" as "ssorriba";
grant index on "ssorriba".telefonos_usuario to "public" as "ssorriba";
grant select on "fiza".vendido to "bs_adm_est2" as "fiza";
grant select on "fiza".vendido to "bs_adm_est1" as "fiza";
grant select on "fiza".vendido to "bs_aux1" as "fiza";
grant update on "fiza".vendido to "bs_aux1" as "fiza";
grant insert on "fiza".vendido to "bs_aux1" as "fiza";
grant select on "fiza".vendido to "public" as "fiza";
grant update on "fiza".vendido to "public" as "fiza";
grant insert on "fiza".vendido to "public" as "fiza";
grant delete on "fiza".vendido to "public" as "fiza";
grant index on "fiza".vendido to "public" as "fiza";
grant select on "fiza".vendido to "bs_aux2" as "fiza";
grant update on "fiza".vendido to "bs_aux2" as "fiza";
grant insert on "fiza".vendido to "bs_aux2" as "fiza";
grant select on "fiza".vendido to "bs_gerente1" as "fiza";
grant select on "fiza".vendido to "bs_gerente2" as "fiza";
grant select on "jbarzi".animales_no_productivos to "bs_adm_est2" as "jbarzi";
grant select on "jbarzi".animales_no_productivos to "bs_aux1" as "jbarzi";
grant update on "jbarzi".animales_no_productivos to "bs_aux1" as "jbarzi";
grant insert on "jbarzi".animales_no_productivos to "bs_aux1" as "jbarzi";
grant delete on "jbarzi".animales_no_productivos to "bs_aux1" as "jbarzi";
grant select on "jbarzi".animales_no_productivos to "bs_adm_est1" as "jbarzi";
grant select on "jbarzi".animales_no_productivos to "bs_aux2" as "jbarzi";
grant update on "jbarzi".animales_no_productivos to "bs_aux2" as "jbarzi";
grant insert on "jbarzi".animales_no_productivos to "bs_aux2" as "jbarzi";
grant delete on "jbarzi".animales_no_productivos to "bs_aux2" as "jbarzi";
grant select on "jbarzi".animales_no_productivos to "public" as "jbarzi";
grant update on "jbarzi".animales_no_productivos to "public" as "jbarzi";
grant insert on "jbarzi".animales_no_productivos to "public" as "jbarzi";
grant delete on "jbarzi".animales_no_productivos to "public" as "jbarzi";
grant index on "jbarzi".animales_no_productivos to "public" as "jbarzi";
grant select on "jbarzi".animales_no_productivos to "bs_gerente1" as "jbarzi";
grant select on "jbarzi".animales_no_productivos to "bs_gerente2" as "jbarzi";
grant select on "jbarzi".toro to "bs_adm_est2" as "jbarzi";
grant select on "jbarzi".toro to "bs_adm_est1" as "jbarzi";
grant select on "jbarzi".toro to "bs_aux1" as "jbarzi";
grant update on "jbarzi".toro to "bs_aux1" as "jbarzi";
grant insert on "jbarzi".toro to "bs_aux1" as "jbarzi";
grant delete on "jbarzi".toro to "bs_aux1" as "jbarzi";
grant select on "jbarzi".toro to "public" as "jbarzi";
grant update on "jbarzi".toro to "public" as "jbarzi";
grant insert on "jbarzi".toro to "public" as "jbarzi";
grant delete on "jbarzi".toro to "public" as "jbarzi";
grant index on "jbarzi".toro to "public" as "jbarzi";
grant select on "jbarzi".toro to "bs_aux2" as "jbarzi";
grant update on "jbarzi".toro to "bs_aux2" as "jbarzi";
grant insert on "jbarzi".toro to "bs_aux2" as "jbarzi";
grant delete on "jbarzi".toro to "bs_aux2" as "jbarzi";
grant select on "jbarzi".toro to "bs_gerente1" as "jbarzi";
grant select on "jbarzi".toro to "bs_gerente2" as "jbarzi";
grant select on "ssorriba".propietario to "bs_adm_est2" as "ssorriba";
grant update on "ssorriba".propietario to "bs_adm_est2" as "ssorriba";
grant insert on "ssorriba".propietario to "bs_adm_est2" as "ssorriba";
grant select on "ssorriba".propietario to "bs_aux1" as "ssorriba";
grant update on "ssorriba".propietario to "bs_aux1" as "ssorriba";
grant insert on "ssorriba".propietario to "bs_aux1" as "ssorriba";
grant select on "ssorriba".propietario to "bs_adm_est1" as "ssorriba";
grant update on "ssorriba".propietario to "bs_adm_est1" as "ssorriba";
grant insert on "ssorriba".propietario to "bs_adm_est1" as "ssorriba";
grant select on "ssorriba".propietario to "bs_aux2" as "ssorriba";
grant update on "ssorriba".propietario to "bs_aux2" as "ssorriba";
grant insert on "ssorriba".propietario to "bs_aux2" as "ssorriba";
grant select on "ssorriba".propietario to "public" as "ssorriba";
grant update on "ssorriba".propietario to "public" as "ssorriba";
grant insert on "ssorriba".propietario to "public" as "ssorriba";
grant delete on "ssorriba".propietario to "public" as "ssorriba";
grant index on "ssorriba".propietario to "public" as "ssorriba";
grant select on "ssorriba".propietario to "bs_gerente1" as "ssorriba";
grant select on "ssorriba".propietario to "bs_gerente2" as "ssorriba";
grant select on "jbarzi".vaca to "bs_adm_est2" as "jbarzi";
grant select on "jbarzi".vaca to "bs_aux1" as "jbarzi";
grant update on "jbarzi".vaca to "bs_aux1" as "jbarzi";
grant insert on "jbarzi".vaca to "bs_aux1" as "jbarzi";
grant delete on "jbarzi".vaca to "bs_aux1" as "jbarzi";
grant select on "jbarzi".vaca to "bs_adm_est1" as "jbarzi";
grant select on "jbarzi".vaca to "bs_aux2" as "jbarzi";
grant update on "jbarzi".vaca to "bs_aux2" as "jbarzi";
grant insert on "jbarzi".vaca to "bs_aux2" as "jbarzi";
grant delete on "jbarzi".vaca to "bs_aux2" as "jbarzi";
grant select on "jbarzi".vaca to "public" as "jbarzi";
grant update on "jbarzi".vaca to "public" as "jbarzi";
grant insert on "jbarzi".vaca to "public" as "jbarzi";
grant delete on "jbarzi".vaca to "public" as "jbarzi";
grant index on "jbarzi".vaca to "public" as "jbarzi";
grant select on "jbarzi".vaca to "bs_gerente1" as "jbarzi";
grant select on "jbarzi".vaca to "bs_gerente2" as "jbarzi";
grant select on "fiza".enfermedad to "bs_adm_est2" as "fiza";
grant select on "fiza".enfermedad to "bs_aux1" as "fiza";
grant update on "fiza".enfermedad to "bs_aux1" as "fiza";
grant insert on "fiza".enfermedad to "bs_aux1" as "fiza";
grant select on "fiza".enfermedad to "bs_adm_est1" as "fiza";
grant select on "fiza".enfermedad to "bs_aux2" as "fiza";
grant update on "fiza".enfermedad to "bs_aux2" as "fiza";
grant insert on "fiza".enfermedad to "bs_aux2" as "fiza";
grant select on "fiza".enfermedad to "public" as "fiza";
grant update on "fiza".enfermedad to "public" as "fiza";
grant insert on "fiza".enfermedad to "public" as "fiza";
grant delete on "fiza".enfermedad to "public" as "fiza";
grant index on "fiza".enfermedad to "public" as "fiza";
grant select on "fiza".enfermedad to "bs_gerente1" as "fiza";
grant select on "fiza".enfermedad to "bs_gerente2" as "fiza";
grant select on "ipacheco".cria to "bs_adm_est2" as "ipacheco";
grant select on "ipacheco".cria to "bs_aux1" as "ipacheco";
grant update on "ipacheco".cria to "bs_aux1" as "ipacheco";
grant insert on "ipacheco".cria to "bs_aux1" as "ipacheco";
grant delete on "ipacheco".cria to "bs_aux1" as "ipacheco";
grant select on "ipacheco".cria to "bs_aux2" as "ipacheco";
grant update on "ipacheco".cria to "bs_aux2" as "ipacheco";
grant insert on "ipacheco".cria to "bs_aux2" as "ipacheco";
grant delete on "ipacheco".cria to "bs_aux2" as "ipacheco";
grant select on "ipacheco".cria to "bs_gerente1" as "ipacheco";
grant select on "ipacheco".cria to "bs_gerente2" as "ipacheco";
grant select on "ipacheco".cria to "bs_adm_est1" as "ipacheco";
grant select on "ipacheco".cria to "public" as "ipacheco";
grant update on "ipacheco".cria to "public" as "ipacheco";
grant insert on "ipacheco".cria to "public" as "ipacheco";
grant delete on "ipacheco".cria to "public" as "ipacheco";
grant index on "ipacheco".cria to "public" as "ipacheco";
grant select on "fiza".parto to "bs_adm_est2" as "fiza";
grant select on "fiza".parto to "bs_aux1" as "fiza";
grant insert on "fiza".parto to "bs_aux1" as "fiza";
grant select on "fiza".parto to "bs_adm_est1" as "fiza";
grant select on "fiza".parto to "bs_aux2" as "fiza";
grant insert on "fiza".parto to "bs_aux2" as "fiza";
grant select on "fiza".parto to "public" as "fiza";
grant update on "fiza".parto to "public" as "fiza";
grant insert on "fiza".parto to "public" as "fiza";
grant delete on "fiza".parto to "public" as "fiza";
grant index on "fiza".parto to "public" as "fiza";
grant select on "fiza".parto to "bs_gerente1" as "fiza";
grant select on "fiza".parto to "bs_gerente2" as "fiza";
grant select on "ipacheco".campo_de_recria to "bs_adm_est2" as "ipacheco";
grant select on "ipacheco".campo_de_recria to "bs_aux1" as "ipacheco";
grant update on "ipacheco".campo_de_recria to "bs_aux1" as "ipacheco";
grant insert on "ipacheco".campo_de_recria to "bs_aux1" as "ipacheco";
grant delete on "ipacheco".campo_de_recria to "bs_aux1" as "ipacheco";
grant select on "ipacheco".campo_de_recria to "bs_adm_est1" as "ipacheco";
grant select on "ipacheco".campo_de_recria to "bs_aux2" as "ipacheco";
grant update on "ipacheco".campo_de_recria to "bs_aux2" as "ipacheco";
grant insert on "ipacheco".campo_de_recria to "bs_aux2" as "ipacheco";
grant delete on "ipacheco".campo_de_recria to "bs_aux2" as "ipacheco";
grant select on "ipacheco".campo_de_recria to "public" as "ipacheco";
grant update on "ipacheco".campo_de_recria to "public" as "ipacheco";
grant insert on "ipacheco".campo_de_recria to "public" as "ipacheco";
grant delete on "ipacheco".campo_de_recria to "public" as "ipacheco";
grant index on "ipacheco".campo_de_recria to "public" as "ipacheco";
grant select on "ipacheco".campo_de_recria to "bs_gerente1" as "ipacheco";
grant select on "ipacheco".campo_de_recria to "bs_gerente2" as "ipacheco";
grant select on "ipacheco".lotes to "bs_adm_est2" as "ipacheco";
grant select on "ipacheco".lotes to "bs_aux1" as "ipacheco";
grant update on "ipacheco".lotes to "bs_aux1" as "ipacheco";
grant insert on "ipacheco".lotes to "bs_aux1" as "ipacheco";
grant delete on "ipacheco".lotes to "bs_aux1" as "ipacheco";
grant select on "ipacheco".lotes to "bs_adm_est1" as "ipacheco";
grant select on "ipacheco".lotes to "bs_aux2" as "ipacheco";
grant update on "ipacheco".lotes to "bs_aux2" as "ipacheco";
grant insert on "ipacheco".lotes to "bs_aux2" as "ipacheco";
grant delete on "ipacheco".lotes to "bs_aux2" as "ipacheco";
grant select on "ipacheco".lotes to "public" as "ipacheco";
grant update on "ipacheco".lotes to "public" as "ipacheco";
grant insert on "ipacheco".lotes to "public" as "ipacheco";
grant delete on "ipacheco".lotes to "public" as "ipacheco";
grant index on "ipacheco".lotes to "public" as "ipacheco";
grant select on "ipacheco".lotes to "bs_gerente1" as "ipacheco";
grant select on "ipacheco".lotes to "bs_gerente2" as "ipacheco";
grant select on "ipacheco".leche to "bs_adm_est2" as "ipacheco";
grant select on "ipacheco".leche to "bs_aux1" as "ipacheco";
grant select on "ipacheco".leche to "bs_aux2" as "ipacheco";
grant select on "ipacheco".leche to "bs_gerente1" as "ipacheco";
grant select on "ipacheco".leche to "bs_gerente2" as "ipacheco";
grant select on "ipacheco".leche to "bs_adm_est1" as "ipacheco";
grant select on "ipacheco".leche to "public" as "ipacheco";
grant update on "ipacheco".leche to "public" as "ipacheco";
grant insert on "ipacheco".leche to "public" as "ipacheco";
grant delete on "ipacheco".leche to "public" as "ipacheco";
grant index on "ipacheco".leche to "public" as "ipacheco";
grant select on "fiza".servicio to "bs_adm_est2" as "fiza";
grant select on "fiza".servicio to "bs_aux1" as "fiza";
grant update on "fiza".servicio to "bs_aux1" as "fiza";
grant insert on "fiza".servicio to "bs_aux1" as "fiza";
grant select on "fiza".servicio to "bs_adm_est1" as "fiza";
grant select on "fiza".servicio to "bs_aux2" as "fiza";
grant update on "fiza".servicio to "bs_aux2" as "fiza";
grant insert on "fiza".servicio to "bs_aux2" as "fiza";
grant select on "fiza".servicio to "public" as "fiza";
grant update on "fiza".servicio to "public" as "fiza";
grant insert on "fiza".servicio to "public" as "fiza";
grant delete on "fiza".servicio to "public" as "fiza";
grant index on "fiza".servicio to "public" as "fiza";
grant select on "fiza".servicio to "bs_gerente1" as "fiza";
grant select on "fiza".servicio to "bs_gerente2" as "fiza";
grant select on "fiza".convertido to "bs_adm_est2" as "fiza";
grant select on "fiza".convertido to "bs_aux1" as "fiza";
grant update on "fiza".convertido to "bs_aux1" as "fiza";
grant insert on "fiza".convertido to "bs_aux1" as "fiza";
grant delete on "fiza".convertido to "bs_aux1" as "fiza";
grant select on "fiza".convertido to "bs_aux2" as "fiza";
grant update on "fiza".convertido to "bs_aux2" as "fiza";
grant insert on "fiza".convertido to "bs_aux2" as "fiza";
grant delete on "fiza".convertido to "bs_aux2" as "fiza";
grant select on "fiza".convertido to "bs_gerente1" as "fiza";
grant select on "fiza".convertido to "bs_gerente2" as "fiza";
grant select on "fiza".convertido to "bs_adm_est1" as "fiza";
grant select on "fiza".convertido to "public" as "fiza";
grant update on "fiza".convertido to "public" as "fiza";
grant insert on "fiza".convertido to "public" as "fiza";
grant delete on "fiza".convertido to "public" as "fiza";
grant index on "fiza".convertido to "public" as "fiza";
grant select on "jbarzi".separadas_en to "bs_adm_est2" as "jbarzi";
grant select on "jbarzi".separadas_en to "bs_aux1" as "jbarzi";
grant update on "jbarzi".separadas_en to "bs_aux1" as "jbarzi";
grant insert on "jbarzi".separadas_en to "bs_aux1" as "jbarzi";
grant delete on "jbarzi".separadas_en to "bs_aux1" as "jbarzi";
grant select on "jbarzi".separadas_en to "bs_aux2" as "jbarzi";
grant update on "jbarzi".separadas_en to "bs_aux2" as "jbarzi";
grant insert on "jbarzi".separadas_en to "bs_aux2" as "jbarzi";
grant delete on "jbarzi".separadas_en to "bs_aux2" as "jbarzi";
grant select on "jbarzi".separadas_en to "bs_gerente1" as "jbarzi";
grant select on "jbarzi".separadas_en to "bs_gerente2" as "jbarzi";
grant select on "jbarzi".separadas_en to "bs__adm_est1" as "jbarzi";
grant select on "jbarzi".separadas_en to "public" as "jbarzi";
grant update on "jbarzi".separadas_en to "public" as "jbarzi";
grant insert on "jbarzi".separadas_en to "public" as "jbarzi";
grant delete on "jbarzi".separadas_en to "public" as "jbarzi";
grant index on "jbarzi".separadas_en to "public" as "jbarzi";
grant select on "ssorriba".producen to "bs_adm_est2" as "ssorriba";
grant select on "ssorriba".producen to "bs_aux1" as "ssorriba";
grant update on "ssorriba".producen to "bs_aux1" as "ssorriba";
grant insert on "ssorriba".producen to "bs_aux1" as "ssorriba";
grant select on "ssorriba".producen to "bs_adm_est1" as "ssorriba";
grant select on "ssorriba".producen to "bs_aux2" as "ssorriba";
grant update on "ssorriba".producen to "bs_aux2" as "ssorriba";
grant insert on "ssorriba".producen to "bs_aux2" as "ssorriba";
grant select on "ssorriba".producen to "public" as "ssorriba";
grant update on "ssorriba".producen to "public" as "ssorriba";
grant insert on "ssorriba".producen to "public" as "ssorriba";
grant delete on "ssorriba".producen to "public" as "ssorriba";
grant index on "ssorriba".producen to "public" as "ssorriba";
grant select on "ssorriba".producen to "bs_gerente1" as "ssorriba";
grant select on "ssorriba".producen to "bs_gerente2" as "ssorriba";
grant select on "jbarzi".se_dirige to "bs_adm_est2" as "jbarzi";
grant select on "jbarzi".se_dirige to "bs_aux1" as "jbarzi";
grant update on "jbarzi".se_dirige to "bs_aux1" as "jbarzi";
grant insert on "jbarzi".se_dirige to "bs_aux1" as "jbarzi";
grant delete on "jbarzi".se_dirige to "bs_aux1" as "jbarzi";
grant select on "jbarzi".se_dirige to "bs_aux2" as "jbarzi";
grant update on "jbarzi".se_dirige to "bs_aux2" as "jbarzi";
grant insert on "jbarzi".se_dirige to "bs_aux2" as "jbarzi";
grant delete on "jbarzi".se_dirige to "bs_aux2" as "jbarzi";
grant select on "jbarzi".se_dirige to "bs_adm_est1" as "jbarzi";
grant select on "jbarzi".se_dirige to "bs_gerente1" as "jbarzi";
grant select on "jbarzi".se_dirige to "public" as "jbarzi";
grant update on "jbarzi".se_dirige to "public" as "jbarzi";
grant insert on "jbarzi".se_dirige to "public" as "jbarzi";
grant delete on "jbarzi".se_dirige to "public" as "jbarzi";
grant index on "jbarzi".se_dirige to "public" as "jbarzi";
grant select on "jbarzi".se_dirige to "bs_gerente2" as "jbarzi";
grant select on "fiza".se_convierte to "bs_adm_est2" as "fiza";
grant select on "fiza".se_convierte to "bs_aux1" as "fiza";
grant update on "fiza".se_convierte to "bs_aux1" as "fiza";
grant insert on "fiza".se_convierte to "bs_aux1" as "fiza";
grant delete on "fiza".se_convierte to "bs_aux1" as "fiza";
grant select on "fiza".se_convierte to "bs_adm_est1" as "fiza";
grant select on "fiza".se_convierte to "bs_aux2" as "fiza";
grant update on "fiza".se_convierte to "bs_aux2" as "fiza";
grant insert on "fiza".se_convierte to "bs_aux2" as "fiza";
grant delete on "fiza".se_convierte to "bs_aux2" as "fiza";
grant select on "fiza".se_convierte to "public" as "fiza";
grant update on "fiza".se_convierte to "public" as "fiza";
grant insert on "fiza".se_convierte to "public" as "fiza";
grant delete on "fiza".se_convierte to "public" as "fiza";
grant index on "fiza".se_convierte to "public" as "fiza";
grant select on "fiza".se_convierte to "bs_gerente1" as "fiza";
grant select on "fiza".se_convierte to "bs_gerente2" as "fiza";
grant select on "pmachin".compuesta_por to "bs_adm_est2" as "pmachin";
grant update on "pmachin".compuesta_por to "bs_adm_est2" as "pmachin";
grant insert on "pmachin".compuesta_por to "bs_adm_est2" as "pmachin";
grant select on "pmachin".compuesta_por to "bs_aux1" as "pmachin";
grant update on "pmachin".compuesta_por to "bs_aux1" as "pmachin";
grant insert on "pmachin".compuesta_por to "bs_aux1" as "pmachin";
grant delete on "pmachin".compuesta_por to "bs_aux1" as "pmachin";
grant select on "pmachin".compuesta_por to "bs_aux2" as "pmachin";
grant update on "pmachin".compuesta_por to "bs_aux2" as "pmachin";
grant insert on "pmachin".compuesta_por to "bs_aux2" as "pmachin";
grant delete on "pmachin".compuesta_por to "bs_aux2" as "pmachin";
grant select on "pmachin".compuesta_por to "bs_gerente1" as "pmachin";
grant select on "pmachin".compuesta_por to "bs_gerente2" as "pmachin";
grant select on "pmachin".compuesta_por to "bs_adm_est1" as "pmachin";
grant update on "pmachin".compuesta_por to "bs_adm_est1" as "pmachin";
grant insert on "pmachin".compuesta_por to "bs_adm_est1" as "pmachin";
grant select on "pmachin".compuesta_por to "public" as "pmachin";
grant update on "pmachin".compuesta_por to "public" as "pmachin";
grant insert on "pmachin".compuesta_por to "public" as "pmachin";
grant delete on "pmachin".compuesta_por to "public" as "pmachin";
grant index on "pmachin".compuesta_por to "public" as "pmachin";
grant select on "pmachin".le_pertenece to "bs_adm_est2" as "pmachin";
grant update on "pmachin".le_pertenece to "bs_adm_est2" as "pmachin";
grant insert on "pmachin".le_pertenece to "bs_adm_est2" as "pmachin";
grant select on "pmachin".le_pertenece to "bs_aux1" as "pmachin";
grant update on "pmachin".le_pertenece to "bs_aux1" as "pmachin";
grant insert on "pmachin".le_pertenece to "bs_aux1" as "pmachin";
grant delete on "pmachin".le_pertenece to "bs_aux1" as "pmachin";
grant select on "pmachin".le_pertenece to "bs_aux2" as "pmachin";
grant update on "pmachin".le_pertenece to "bs_aux2" as "pmachin";
grant insert on "pmachin".le_pertenece to "bs_aux2" as "pmachin";
grant delete on "pmachin".le_pertenece to "bs_aux2" as "pmachin";
grant select on "pmachin".le_pertenece to "bs_gerente1" as "pmachin";
grant select on "pmachin".le_pertenece to "bs_gerente2" as "pmachin";
grant select on "pmachin".le_pertenece to "bs_adm_est1" as "pmachin";
grant update on "pmachin".le_pertenece to "bs_adm_est1" as "pmachin";
grant insert on "pmachin".le_pertenece to "bs_adm_est1" as "pmachin";
grant select on "pmachin".le_pertenece to "public" as "pmachin";
grant update on "pmachin".le_pertenece to "public" as "pmachin";
grant insert on "pmachin".le_pertenece to "public" as "pmachin";
grant delete on "pmachin".le_pertenece to "public" as "pmachin";
grant index on "pmachin".le_pertenece to "public" as "pmachin";
grant select on "pmachin".cuentan_con to "bs_adm_est2" as "pmachin";
grant select on "pmachin".cuentan_con to "bs_aux1" as "pmachin";
grant update on "pmachin".cuentan_con to "bs_aux1" as "pmachin";
grant insert on "pmachin".cuentan_con to "bs_aux1" as "pmachin";
grant select on "pmachin".cuentan_con to "bs_adm_est1" as "pmachin";
grant select on "pmachin".cuentan_con to "bs_aux2" as "pmachin";
grant update on "pmachin".cuentan_con to "bs_aux2" as "pmachin";
grant insert on "pmachin".cuentan_con to "bs_aux2" as "pmachin";
grant select on "pmachin".cuentan_con to "public" as "pmachin";
grant update on "pmachin".cuentan_con to "public" as "pmachin";
grant insert on "pmachin".cuentan_con to "public" as "pmachin";
grant delete on "pmachin".cuentan_con to "public" as "pmachin";
grant index on "pmachin".cuentan_con to "public" as "pmachin";
grant select on "pmachin".cuentan_con to "bs_gerente1" as "pmachin";
grant select on "pmachin".cuentan_con to "bs_gerente2" as "pmachin";
grant select on "pmachin".protagonizan to "bs_adm_est1" as "pmachin";
grant select on "pmachin".protagonizan to "public" as "pmachin";
grant update on "pmachin".protagonizan to "public" as "pmachin";
grant insert on "pmachin".protagonizan to "public" as "pmachin";
grant delete on "pmachin".protagonizan to "public" as "pmachin";
grant index on "pmachin".protagonizan to "public" as "pmachin";
grant select on "pmachin".protagonizan to "bs_adm_est2" as "pmachin";
grant insert on "pmachin".protagonizan to "bs_aux" as "pmachin";
grant select on "pmachin".protagonizan to "bs_aux1" as "pmachin";
grant update on "pmachin".protagonizan to "bs_aux1" as "pmachin";
grant select on "pmachin".protagonizan to "bs_aux2" as "pmachin";
grant update on "pmachin".protagonizan to "bs_aux2" as "pmachin";
grant insert on "pmachin".protagonizan to "bs_aux2" as "pmachin";
grant select on "pmachin".protagonizan to "bs_gerente1" as "pmachin";
grant select on "pmachin".protagonizan to "bs_gerente2" as "pmachin";
grant select on "pmachin".entore to "bs_adm_est2" as "pmachin";
grant insert on "pmachin".entore to "bs_aux" as "pmachin";
grant select on "pmachin".entore to "bs_adm_est1" as "pmachin";
grant select on "pmachin".entore to "bs_aux1" as "pmachin";
grant update on "pmachin".entore to "bs_aux1" as "pmachin";
grant select on "pmachin".entore to "public" as "pmachin";
grant update on "pmachin".entore to "public" as "pmachin";
grant insert on "pmachin".entore to "public" as "pmachin";
grant delete on "pmachin".entore to "public" as "pmachin";
grant index on "pmachin".entore to "public" as "pmachin";
grant select on "pmachin".entore to "bs_aux2" as "pmachin";
grant update on "pmachin".entore to "bs_aux2" as "pmachin";
grant insert on "pmachin".entore to "bs_aux2" as "pmachin";
grant select on "pmachin".entore to "bs_gerente1" as "pmachin";
grant select on "pmachin".entore to "bs_gerente2" as "pmachin";
grant select on "pmachin".tienen to "bs_adm_est2" as "pmachin";
grant select on "pmachin".tienen to "bs_adm_est1" as "pmachin";
grant select on "pmachin".tienen to "bs_aux1" as "pmachin";
grant update on "pmachin".tienen to "bs_aux1" as "pmachin";
grant insert on "pmachin".tienen to "bs_aux1" as "pmachin";
grant select on "pmachin".tienen to "public" as "pmachin";
grant update on "pmachin".tienen to "public" as "pmachin";
grant insert on "pmachin".tienen to "public" as "pmachin";
grant delete on "pmachin".tienen to "public" as "pmachin";
grant index on "pmachin".tienen to "public" as "pmachin";
grant select on "pmachin".tienen to "bs_aux2" as "pmachin";
grant update on "pmachin".tienen to "bs_aux2" as "pmachin";
grant insert on "pmachin".tienen to "bs_aux2" as "pmachin";
grant select on "pmachin".tienen to "bs_gerente1" as "pmachin";
grant select on "pmachin".tienen to "bs_gerente2" as "pmachin";
grant select on "pmachin".salen to "bs_adm_est2" as "pmachin";
grant select on "pmachin".salen to "bs_aux1" as "pmachin";
grant update on "pmachin".salen to "bs_aux1" as "pmachin";
grant insert on "pmachin".salen to "bs_aux1" as "pmachin";
grant delete on "pmachin".salen to "bs_aux1" as "pmachin";
grant select on "pmachin".salen to "bs_adm_est1" as "pmachin";
grant select on "pmachin".salen to "bs_aux2" as "pmachin";
grant update on "pmachin".salen to "bs_aux2" as "pmachin";
grant insert on "pmachin".salen to "bs_aux2" as "pmachin";
grant delete on "pmachin".salen to "bs_aux2" as "pmachin";
grant select on "pmachin".salen to "public" as "pmachin";
grant update on "pmachin".salen to "public" as "pmachin";
grant insert on "pmachin".salen to "public" as "pmachin";
grant delete on "pmachin".salen to "public" as "pmachin";
grant index on "pmachin".salen to "public" as "pmachin";
grant select on "pmachin".salen to "bs_gerente1" as "pmachin";
grant select on "pmachin".salen to "bs_gerente2" as "pmachin";








 


 


 


 


 


 


revoke usage on language SPL from public ;

grant usage on language SPL to public ;






alter table "ssorriba".usuarios add constraint (foreign key (nro_bps) 
    references "ssorriba".cooperativa  on delete cascade constraint 
    "ssorriba".fk2usuarios);

alter table "ssorriba".establecimientos add constraint (foreign 
    key (nro_bps) references "ssorriba".cooperativa  on delete 
    cascade constraint "ssorriba".fkestablecimientos);

alter table "ssorriba".telefonos_establecimiento add constraint 
    (foreign key (nro_dicose) references "ssorriba".establecimientos 
     on delete cascade constraint "ssorriba".fktelestablecimiento);
    

alter table "ssorriba".usuarios add constraint (foreign key (id) 
    references "ssorriba".tipos_de_usuario  on delete cascade 
    constraint "ssorriba".fk1usuarios);

alter table "jbarzi".animales add constraint (foreign key (nro_dicose) 
    references "ssorriba".establecimientos  on delete cascade 
    constraint "jbarzi".fkanimales);

alter table "jbarzi".animales add constraint (foreign key (id_animal) 
    references "jbarzi".tipos_de_animales  on delete cascade constraint 
    "jbarzi".fkanimales2);

alter table "fiza".enfermedad add constraint (foreign key (nro_evento) 
    references "fiza".eventos  on delete cascade constraint "fiza"
    .fkenfermedad);

alter table "ssorriba".telefonos_usuario add constraint (foreign 
    key (ci) references "ssorriba".usuarios  on delete cascade 
    constraint "ssorriba".fktelusuarios);

alter table "jbarzi".animales_no_productivos add constraint (foreign 
    key (nro_identificador) references "jbarzi".animales  on delete 
    cascade constraint "jbarzi".fkanimalesnoproductivos);

alter table "jbarzi".toro add constraint (foreign key (nro_identificador) 
    references "jbarzi".animales  on delete cascade constraint 
    "jbarzi".fktoro);

alter table "jbarzi".vaca add constraint (foreign key (nro_identificador) 
    references "jbarzi".animales  on delete cascade constraint 
    "jbarzi".fkvaca);

alter table "fiza".eventos add constraint (foreign key (nro_animal) 
    references "jbarzi".animales  on delete cascade constraint 
    "fiza".fk1);

alter table "fiza".eventos add constraint (foreign key (id_evento) 
    references "fiza".tipos_de_eventos  on delete cascade constraint 
    "fiza".fk2);

alter table "jbarzi".muerte add constraint (foreign key (nro_evento) 
    references "fiza".eventos  on delete cascade constraint "jbarzi"
    .fkmuerte);

alter table "ipacheco".cria add constraint (foreign key (nro_identificador) 
    references "jbarzi".animales  on delete cascade constraint 
    "ipacheco".fkcria);

alter table "jbarzi".se_dirige add constraint (foreign key (nro_identificador) 
    references "jbarzi".animales  on delete cascade constraint 
    "jbarzi".fksedirige);

alter table "jbarzi".separadas_en add constraint (foreign key 
    (nro_identificador) references "jbarzi".animales  on delete 
    cascade constraint "jbarzi".fkseparadasen);

alter table "ipacheco".campo_de_recria add constraint (foreign 
    key (nro_animal) references "jbarzi".animales  on delete cascade 
    constraint "ipacheco".fkcamporecria1);

alter table "ipacheco".campo_de_recria add constraint (foreign 
    key (nro_establecimiento) references "ssorriba".establecimientos 
     on delete cascade constraint "ipacheco".fkcamporecria2);

alter table "fiza".servicio add constraint (foreign key (nro_evento) 
    references "fiza".eventos  on delete cascade constraint "fiza"
    .fk1servicio);

alter table "fiza".servicio add constraint (foreign key (id_servicio) 
    references "jbarzi".tipos_de_servicio  on delete cascade constraint 
    "fiza".fk2servicio);

alter table "fiza".telefonos_propietario add constraint (foreign 
    key (ci) references "ssorriba".propietario  on delete cascade 
    constraint "fiza".fk1tel);

alter table "fiza".vendido add constraint (foreign key (nro_evento) 
    references "fiza".eventos  on delete cascade constraint "fiza"
    .fk1vendido);

alter table "ssorriba".producen add constraint (foreign key (tipo) 
    references "ipacheco".leche  on delete cascade constraint 
    "ssorriba".fkproducen);

alter table "ssorriba".producen add constraint (foreign key (nro_lote) 
    references "ipacheco".lotes  on delete cascade constraint 
    "ssorriba".fkproducen2);

alter table "pmachin".compuesta_por add constraint (foreign key 
    (nro_bps) references "ssorriba".cooperativa  on delete cascade 
    constraint "pmachin".fkcompuestapor);

alter table "pmachin".compuesta_por add constraint (foreign key 
    (nro_dicose) references "ssorriba".establecimientos  on delete 
    cascade constraint "pmachin".fkcompuestapor2);

alter table "pmachin".le_pertenece add constraint (foreign key 
    (nro_dicose) references "ssorriba".establecimientos  on delete 
    cascade constraint "pmachin".fklepertenece1);

alter table "pmachin".le_pertenece add constraint (foreign key 
    (ci) references "ssorriba".propietario  on delete cascade 
    constraint "pmachin".fklepertenece2);

alter table "ssorriba".establecimientos add constraint (foreign 
    key (ci_propietario) references "ssorriba".propietario  on 
    delete cascade constraint "ssorriba".fkestablecimiento2);

alter table "pmachin".cuentan_con add constraint (foreign key 
    (nro_dicose) references "ssorriba".establecimientos  on delete 
    cascade constraint "pmachin".fkcuentancon);

alter table "pmachin".cuentan_con add constraint (foreign key 
    (nro_animal) references "jbarzi".animales  on delete cascade 
    constraint "pmachin".fkcuentancon2);

alter table "pmachin".protagonizan add constraint (foreign key 
    (nro_identificador) references "jbarzi".animales  on delete 
    cascade constraint "pmachin".fkprotagonizan);

alter table "pmachin".protagonizan add constraint (foreign key 
    (nro_evento) references "fiza".eventos  on delete cascade 
    constraint "pmachin".fkprotagonizan2);

alter table "pmachin".entore add constraint (foreign key (nro_identificador_toro) 
    references "jbarzi".animales  on delete cascade constraint 
    "pmachin".fkentore1);

alter table "pmachin".entore add constraint (foreign key (nro_identificador_vaca) 
    references "jbarzi".animales  on delete cascade constraint 
    "pmachin".fkentore2);

alter table "pmachin".tienen add constraint (foreign key (nro_identificador_toro,
    nro_identificador_vaca) references "pmachin".entore  on delete 
    cascade constraint "pmachin".fktienen);

alter table "pmachin".tienen add constraint (foreign key (nro_identificador_cria) 
    references "ipacheco".cria  on delete cascade constraint "pmachin"
    .fktienen2);

alter table "pmachin".salen add constraint (foreign key (nro_identificador) 
    references "jbarzi".animales  on delete cascade constraint 
    "pmachin".fksalen);

alter table "fiza".se_convierte add constraint (foreign key (nro_identificador) 
    references "jbarzi".animales  on delete cascade constraint 
    "fiza".fksecon);

alter table "fiza".convertido add constraint (foreign key (nro_identificador) 
    references "jbarzi".animales  on delete cascade constraint 
    "fiza".fkconv);

alter table "fiza".parto add constraint (foreign key (nro_evento) 
    references "fiza".eventos  on delete cascade constraint "fiza"
    .fkparto);

alter table "jbarzi".separadas_en add constraint (foreign key 
    (nro_lote) references "ipacheco".lotes  on delete cascade 
    constraint "jbarzi".fkseparadasen2);





 


