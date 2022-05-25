create database EMPRESA_DB
GO
use EMPRESA_DB
GO

create table empleados (
id_empleado int identity primary key,
nombre varchar(100) not null,
apellido varchar(100) not null,
id_puesto int not null,
salario float not null,
esta_activo bit not null,
fecha_alta date not null,
fecha_baja date,
mail varchar(150)
)

create table puestos (
id_puesto int primary key,
nombre varchar(200),
nivel_autorizacion int
)

insert into puestos (id_puesto, nombre, nivel_autorizacion) 
values 
(1,'Director',3),
(2,'Gerente',3),
(3,'Jefe de sector',2),
(4,'Administrativo',1),
(5,'Vendedor',0),
(6,'Secretario',2)

insert into empleados (nombre, apellido, id_puesto, salario, esta_activo, fecha_alta,fecha_baja,mail)
values 
('Leilani','Kinney',1,383946.80,1,'1996/03/21', null,'lkinney@gmail.com'),
('Igor','England',3,283558.85,1,'2013/03/28', null,'iengland@hotmail.com'),
('Maya','Brock',5,164546.09,1,'1993/10/24', null,null),
('Hayden','Moss',4,211695.50,0,'2012/06/07', '2015/02/19','hmoss@gmail.com'),
('Amal','Colon',2,388933.60,1,'2019/09/23', null,null)

--muestro las tablas como estan en el ejercicio
select * from puestos
select empleados.nombre, empleados.apellido, puestos.nombre as puesto, empleados.salario, empleados.esta_activo, empleados.fecha_alta, empleados.fecha_baja, mail
from empleados inner join puestos on empleados.id_puesto = puestos.id_puesto

--muestro lo que piden

--PUNTO 4
-- 1
select * from empleados
--2
select nombre from puestos
--3
select * from empleados where esta_activo = 1
--4
select * from empleados where salario > 200000.00
--5
select * from empleados where fecha_alta <= '2012/06/07'
--6
select * from empleados where mail is null
--7
select * from empleados where mail is not null
--8
select * from empleados where mail like '%gmail%'--contains(mail,'gmail')
--9
select * from empleados where apellido like 'B%'

--PUNTO 5
--1
select * from empleados where esta_activo = 1 and salario > 300000.00
--2
select * from empleados where mail is null or esta_activo = 0
--3
select * from empleados where mail is not null and nombre like '%a%'--contains(nombre,'a')
--4
select * from empleados where salario >= 250000.00 and fecha_alta >= '2000-01-01'
or salario < 250000.00 and fecha_alta < '2000-01-01'
--5
select * from empleados where salario between 100000.00 and 250000.00
--6
select * from empleados where salario <= 100000.00 or salario >= 250000.00
--7
select * from puestos where 
nivel_autorizacion = 0 
or nivel_autorizacion = 1 
or nivel_autorizacion = 2
--8
select * from puestos where
nivel_autorizacion != 0
and nivel_autorizacion != 1 
and nivel_autorizacion != 2

--PUNTO 6
--1
select * from empleados where esta_activo = 1 order by apellido asc
--2
select top(3) * from empleados order by fecha_alta asc
--3
select top(3) * from empleados order by salario desc
--4
select * from empleados order by salario desc
--5
select nivel_autorizacion from puestos group by nivel_autorizacion

--PUNTO 7
--1
select empleados.nombre, empleados.apellido, puestos.nombre 
from empleados inner join puestos on empleados.id_puesto = puestos.id_puesto
--2
select empleados.nombre, empleados.apellido, puestos.nombre, puestos.nivel_autorizacion 
from empleados inner join puestos on empleados.id_puesto = puestos.id_puesto and puestos.nivel_autorizacion = 3
--3
select empleados.nombre, empleados.apellido, puestos.nombre 
from empleados inner join puestos on empleados.id_puesto = puestos.id_puesto order by empleados.apellido asc
--4
select empleados.nombre, empleados.apellido, puestos.nombre 
from empleados inner join puestos on empleados.id_puesto = puestos.id_puesto order by puestos.nombre asc
--5
select empleados.nombre, empleados.apellido, puestos.nombre, puestos.nivel_autorizacion
from empleados inner join puestos on empleados.id_puesto = puestos.id_puesto 
where empleados.esta_activo = 1 order by puestos.nivel_autorizacion asc
--6
select * from puestos
--7