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
select * from empleados where salario >= 250000.00 and fecha_alta >= '2000'
or salario < 250000.00 and fecha_alta < '2000'
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
select puestos.nombre from puestos
left join empleados on empleados.id_puesto = puestos.id_puesto 
where empleados.id_puesto is null
--7
select puestos.nombre from puestos
inner join empleados on empleados.id_puesto = puestos.id_puesto 


--PUNTO 8
--1
select avg(salario) as promedio from empleados where esta_activo = 1
--deberia darme: 305245 aprox
--2
select sum(salario) as suma from empleados where esta_activo = 1
--3
select count(nombre) from empleados where salario > 250000.00
--4
select count(nombre) from empleados where fecha_alta < '2010'
--5
select * from empleados where salario = (select max(salario) from empleados)
--6
select * from puestos where nivel_autorizacion = (select min(nivel_autorizacion) from puestos)
--7
select CONCAT(nombre,' ',apellido) as nombre_completo from empleados
--8
select CONCAT(empleados.nombre,' ',apellido) as nombre_completo, puestos.nombre, puestos.nivel_autorizacion 
from empleados inner join puestos on empleados.id_puesto = puestos.id_puesto
--9
select CONCAT(empleados.nombre,' ',apellido) as nombre_completo, puestos.nombre, puestos.nivel_autorizacion
from empleados inner join puestos on empleados.id_puesto = puestos.id_puesto
select CONCAT(empleados.nombre,' ',apellido) as nombre_completo, puestos.nombre, puestos.nivel_autorizacion 
from puestos left join empleados on empleados.id_puesto = puestos.id_puesto where empleados.id_puesto is null


/** REVISAR LO ANTERIOR; LO PIDE EN UNA SOLA CONSULTA**/

--PUNTO 9
--1
select count(*) cantidad from empleados group by empleados.id_puesto
--2
select avg(salario) promedio_salario from empleados group by empleados.id_puesto
--3
select nombre, apellido, salario from empleados where salario = (select max(salario) from empleados)
--4
select empleados.nombre, empleados.apellido, puestos.nombre, puestos.nivel_autorizacion 
from empleados inner join puestos on empleados.id_puesto = puestos.id_puesto
where puestos.nivel_autorizacion =(select max(puestos.nivel_autorizacion) from puestos)
--5
select top(1)* from empleados order by fecha_alta asc
--6
select * from empleados where salario > (select avg(salario) from empleados)
--7
select count(*) cantidad from empleados where salario > (select avg(salario) from empleados)

--PUNTO 10
update empleados set mail = 'mbrock@yahoo.com' where id_empleado = 3
select * from empleados where id_empleado = 3
--PUNTO 11
update empleados set id_puesto = 4, salario = 210000.00 where id_empleado = 3
select empleados.nombre, empleados.apellido, puestos.nombre as puesto, empleados.salario, empleados.esta_activo, empleados.fecha_alta, empleados.fecha_baja, mail
from empleados inner join puestos on empleados.id_puesto = puestos.id_puesto where id_empleado = 3
--PUNTO 12
update empleados set salario += salario * 0.25 where salario <250000.00
select empleados.nombre, empleados.apellido, puestos.nombre as puesto, empleados.salario, empleados.esta_activo, empleados.fecha_alta, empleados.fecha_baja, mail
from empleados inner join puestos on empleados.id_puesto = puestos.id_puesto--(select iif(esta_activo = 0,'no','si') from empleados)
--PUNTO 13: EXPORTAR
--BACKUP DATABASE EMPRESA_DB TO DISK = 'filepath' 
--SUPUESTAMENTE ANDA, sino desde click derecho -> tasks -> backup
--PUNTO 14
update empleados set esta_activo = 0, fecha_baja = GETDATE() where id_empleado = 1
select * from empleados where id_empleado = 1
--PUNTO 15
delete from empleados where esta_activo = 0
select * from empleados
--PUNTO 16
