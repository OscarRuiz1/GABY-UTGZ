create database Cosmeticos
use cosmeticos 
create table Permiso
(
id int identity (1,1),
Nombre varchar(25),
constraint pk_idPermiso primary key (id),
)
use Cosmeticos 
create table Puesto 
(
id int identity (1,1),
Nombre varchar (15),
Sueldo int,
Horario varchar (25),
constraint pk_idpuesto primary key (id),
)
use Cosmeticos 
create table Empleado
(
id int identity (1,1),
id_puesto int,
Nombre varchar (25),
Apepat varchar (15),
Apemat varchar (15),
Direccion varchar (35),
Telefono varchar (25),
Correo varchar(35),
constraint pk_idempleado primary key (id),
constraint fk_idpuesto foreign key (id_puesto) references puesto,
)
use Cosmeticos 
create table Cliente
(
id int identity (1,1),
Nombre varchar (15),
Apepat varchar (25),
Direccio varchar (25),
Telefono varchar (25),
Sexo varchar (2),
Correo varchar (30),
constraint pk_idCliente primary key (id),
)
use Cosmeticos 
create table Usuario
(
id int identity (1,1),
id_permiso int,
Id_Empleado int,
Id_Cliente int,
NombreU varchar(25),
Contraseña varchar(30),
constraint pk_idUsuario primary key (id),
constraint fk_idPerm foreign key (id_Permiso) references Permiso,
constraint fk_idPEmpleado foreign key (id_Empleado) references Empleado,
constraint fk_idCliente foreign key (id_Cliente) references Cliente
)

use Cosmeticos 
create table Proveedor
(
id int identity (1,1),
Nombre varchar (25),
Telefono varchar (25),
Correo varchar (30),
Direccion varchar (25),
constraint pk_idProveedor primary key (id),
)
use Cosmeticos
create table Linea
(
id int identity (1,1),
Nombre varchar (25),
constraint pk_idLinea primary key (id),
)
use Cosmeticos 
create table Producto
(
id int identity (1,1),
id_linea int,
id_cliente int,
id_Proveedor int,
Nombre varchar (25),
Marca varchar (25),
Descripcion varchar (30),
Precio int,
constraint pk_idProducto primary key (id),
constraint fk_idLinea foreign key (id_Linea) references Linea,
constraint fk_idClient foreign key (id_Cliente) references Cliente,
constraint fk_idProveedor foreign key (id_Proveedor) references Proveedor
)

insert into Permiso  values ('Empleado')
insert into Permiso  values ('Cliente')
insert into Permiso  values ('Empleado')
insert into Permiso  values ('Cliente')
insert into Permiso  values ('Empleado')
Select * from Permiso 
update Permiso set Nombre= id +3 where id=2

insert into puesto values ('vendedor',600,' 9am-3pm')
insert into puesto values ('diseñador',500,' 8am-3pm')
insert into puesto values ('publicista',800,' 7am-1pm')
insert into puesto values ('vinculacion',1000,' 8am-4pm')
insert into puesto values ('dueña',2000,' 8am-pm')
Select * from puesto 

insert into empleado   values (1,'juanito','castellanos','Hernandez','las flores','2261072351','juan.leo@gmail.com')
insert into empleado   values (2,'jiuber','Monfil','Quijano','el mirador','2251087091','JiuberMq97@hotmail.com')
insert into empleado   values (3,'Gerardo','Mora','Guevara','Centro Alt.','2261000677','Asgust67@gmail.com')
insert into empleado   values (4,'Jesus','Segura','Garcia','el ranchito 43','2341191862','Jashua.67@gmail.com')
insert into empleado   values (5,'Jair','Ramirez','Hernandez','juarez 43','2261072351','Jair.76mjh@gmail.com')
select * from empleado 

insert into Cliente values ('Karina','Santos','Altotonga','2261094323','M','Kary.trf54@gmail.com')
insert into Cliente values ('Juana','Salas','Altotonga','2261094323','M','Kary.trf54@gmail.com')
insert into Cliente values ('Elizabeth','Seguara','Altotonga','2261094323','M','Kary.trf54@gmail.com')
insert into Cliente values ('Vianey','Quinto','Altotonga','2261094323','M','Kary.trf54@gmail.com')
insert into Cliente values ('Mayra','Martinez','Altotonga','2261094323','M','Kary.trf54@gmail.com')
select * from Cliente 
delete from Cliente

insert into Usuario values (1,1,1,'juan','tartagshdh')
insert into Usuario values (2,2,2,'Pedro','dghgdtr56')
insert into Usuario values (3,3,3,'Carlos','567tdetr')
insert into Usuario values (4,4,4,'Martin','ydaa453')
insert into Usuario values (5,5,5,'Elias','7854dsat')
select * from Usuario
DELETE FROM Usuario 

insert into Proveedor values ('Natura','1231453436','natu.56@gmail.com','Mexico DF')
insert into Proveedor values ('Jafra','7821435234','Jafra65.45@gmail.com','Puebla')
insert into Proveedor values ('Avon','9176543213','Avon.tdre@gmail.com','Veracruz')
insert into Proveedor values ('Fuller','0180028765','Fuller.edy@gmail.com','Tlaxcala')
insert into Proveedor values ('House','6546787624','Hous.edtr54@gmail.com','Jalisco')
select * from Proveedor 

insert into Linea  values ('maquillaje')
insert into Linea  values ('Perfumeria')
insert into Linea  values ('Rostro')
insert into Linea  values ('Cuerpo')
insert into Linea  values ('Baño')
select * from Linea 


insert into Producto values (1,1,1,'rimen','Jafra','es color negro',76)
insert into Producto values (2,2,2,'fragancia','Natura','es de 500ml',300)
insert into Producto values (3,3,3,'delinador','Avon','es de color cafe',120)
insert into Producto values (4,4,4,'locion','Fuller','100ml',150)
insert into Producto values (5,5,5,'javon','House','hecho de rosas',760)
select * from Producto 

select d.nombre as 'Proveedor', a.nombre as 'Producto',a.descripcion as 'Descripcion',a.precio AS 'Precio',c.nombre as 'Cliente',b.nombre as'Linea' from Producto  a
inner join Proveedor   d on a.id_proveedor=d.id 
inner join  cliente c on a.id_cliente=c.id 
inner join  Linea b on a.id_Linea =b.id 
 
select e.NombreU as 'Usuario',f.Nombre as 'Permiso',g.Nombre as 'Cliente',g.Apepat as 'Apellidp Paterno',h.Nombre as 'Empleado',h.Apemat as 'Apellido paterno', i.Nombre as 'Puesto',i.Sueldo as 'Sueldo',i.Horario as 'Horaio de trabajo'  from Usuario e
inner join Permiso f on E.id_Permiso = f.id
inner join Cliente G on E.id_Cliente = G.id
inner join Empleado H on E.id_Empleado =H.id
inner join Puesto I on h.id_Puesto = I.Id
 select * from Empleado 