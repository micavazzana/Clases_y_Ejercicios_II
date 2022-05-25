create table productos(
id int identity primary key,
nombre varchar(50) not null,
codigo_de_barras varchar(50) not null,
tipo varchar(50) not null,
stock int not null,
precio float not null,
fecha_de_creacion date not null,
fecha_de_modificacion date not null
)
go
create table usuario(
id int identity primary key,
nombre varchar(50) not null,
apellido varchar(50) not null,
clave varchar(50) not null,
mail varchar(50) not null,
fecha_de_registro date not null,
localidad varchar(50) not null,
)

go
create table ventas(
id int identity primary key,
id_producto int not null,
id_usuario int not null,
cantidad int not null,
fecha_de_venta date not null,
)

INSERT INTO productos (CODIGO_DE_BARRAS,NOMBRE,TIPO,STOCK,PRECIO,FECHA_DE_CREACION,FECHA_DE_MODIFICACION) VALUES
(77900363,'Newgrosh','polvo',14,68.19,'2020/11/29','2021/11/02'),
(77900364,'McNickle','polvo',19,53.51,'2020/11/28','2020/10/17'),
(77900365,'Hudd','solido',68,26.56,'2020/12/19','2020/06/19'),
(77900366,'Schrader','polvo',17,96.54,'2020/08/02','2020/04/18'),
(77900367,'Bachellier','solido',59,69.17,'2021/01/30','2020/06/07'),
(77900368,'Fleming','solido',38,66.77,'2020/10/26','2020/10/03'),
(77900369,'Hurry','solido',44,43.01,'2021/07/04','2020/05/30'),
(77900310,'Krauss','polvo',73,35.73,'2021/03/03','2020/08/30');

INSERT INTO usuario (nombre,apellido,clave,mail,fecha_de_registro,localidad) VALUES ('Mariano','Kautor','2345','dkantor0@example.com','2021/07/01','Quilmes'),
('German','Gerram','1234','ggerram1@hud.gov','2020/08/05','Berazategui'),
('Deloris','Fosis','5678','bsharpe2@wisc.edu','2020/11/28','Avellaneda'),
('Brok','Neiner','4567','bblazic3@desdev.cn','2020/08/12','Quilmes'),
('Garrick','Brent','6789','gbrent4@theguardian.com','2020/12/17','Moron'),
('Bili','Baus','0123','bhoff5@addthis.com','2020/11/27','Moreno');

INSERT INTO ventas (id_producto, id_usuario,cantidad,fecha_de_venta) VALUES (1,1,2,'2020/07/19'),
(8,2,3,'2020/08/16'),
(7,2,4,'2021/01/24'),
(6,3,5,'2021/01/14'),
(3,4,6,'2021/03/20'),
(5,5,7,'2021/02/22'),
(3,4,6,'2021/12/01'),
(3,6,6,'2020/06/10'),
(2,6,6,'2021/04/02'),
(1,6,1,'2020/05/17');

select * from usuario
select * from ventas
select * from productos

---- me trae la data de la relacion que le pido
select ventas.id, ventas.cantidad, ventas.id_producto, 
productos.id, productos.nombre 
from ventas inner join productos on ventas.id_producto = productos.id

--
select ventas.id, ventas.cantidad*productos.precio as importe
from ventas inner join productos on ventas.id_producto = productos.id

--
select * from ventas left join productos on ventas.id_producto = productos.id
select * from ventas right join productos on ventas.id_producto = productos.id

--
select ventas.id_usuario, usuario.id, usuario.nombre, 
(ventas.cantidad * productos.precio) as importe
from ventas inner join usuario on ventas.id_usuario = usuario.id
inner join productos on ventas.id_producto = productos.id

update usuario set nombre = 'Marian' where id = 1
select * from usuario
-- delete from usuario where nombre = 'Marian'

select * from productos where tipo = 'polvo' 

select sum(cantidad) cantidad_total from ventas

select top(3) productos.nombre from ventas
inner join productos on ventas.id_producto = productos.id
order by ventas.id asc

