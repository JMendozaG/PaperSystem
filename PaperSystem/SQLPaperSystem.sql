create database PaperSystem

use PaperSystem

create table maestro(
NumMaestro int,
NomMaestro varchar(50),
AreaMaestro varchar(30),
primary key(NumMaestro)
)

create table Copias (
Folio int,
NumCopias int,
NumMaestro int,
TipoMaterial varchar(30),
primary key (Folio),
Foreign key (NumMaestro) references maestro(NumMaestro)
)

Create table Papeleria(
NumProducto int,
NombreProducto varchar(30),
cantidad int,
FechaLlegada varchar(50),
primary key (NumProducto)
)

create table usuarios(
usuario varchar(20),
contraseña varchar(20),
administrador int,
primary key (usuario)
)

drop database PaperSystem;
select Folio, maestro.NumMaestro, NomMaestro, NumCopias ,TipoMaterial from Copias inner join maestro on maestro.NumMaestro = Copias.NumMaestro;

create view VistaCopias as select Folio, Copias.NumMaestro, NomMaestro, Numcopias, TipoMaterial from Copias, maestro where maestro.NumMaestro = Copias.NumMaestro;

drop view vistaCopias;
select*from VistaCopias;

select*from Papeleria;

update Papeleria set FechaLlegada = FechaLlegada varchar(50);

DELETE FROM usuarios WHERE usuario = 'Prueba3'