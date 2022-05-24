create database DIV2ESQL
GO
use DIV2ESQL
GO
create table personas(
id int identity primary key,
nombre varchar(20) not null,
apellido varchar(20) not null,
fechaNacimiento date not null,
idDireccion int not null,
idCalificacion int not null
)
create table calificaciones(
id int identity primary key,
calificacion float not null
)

--INSERTAR DATOS--

insert into personas (nombre,apellido,fechaNacimiento,idDireccion,idCalificacion) 
values('Mica','Vazzana','1989/09/28',1,1), ('Don','Gato','1986/05/22',2,2);

insert into calificaciones(calificacion) values (7.8), (6),(9);

-- obtener datos //PARA OBTENER TODOS LOS DATOS USO *
select * from personas
-- obtener nombres
select nombre from personas
--obtener nombre y apellidos
select nombre,apellido from personas

--filtrar datos
select * from personas where id = 2;

--ordenar por nombre
select * from personas order by nombre DESC


--borrar
delete from personas where id = 2
select * from personas

select * from calificaciones

---------------------------------- TRAYENDO UNA TABLA DE MOCKAROO:

create table personas_mock (
	id int identity primary key,
	nombre varchar(20),
	apellido varchar(20),
	fechaNacimiento date
);

insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Allis', 'Nockalls', '2013-11-05');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Rhianon', 'Fluck', '2007-08-17');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Lionel', 'Riglesford', '2011-01-31');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Hillery', 'St. Leger', '2009-05-03');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Kip', 'Blazey', '2020-02-27');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Marchelle', 'Pimmocke', '2008-06-02');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Crichton', 'Gillbanks', '2019-04-02');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Zia', 'Pooley', '2008-01-14');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Julius', 'Rolse', '2015-08-25');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Glendon', 'Ilive', '2015-10-10');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Jessie', 'Mathivon', '2019-08-14');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Odessa', 'Lyal', '2016-04-28');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Siana', 'Sillwood', '2007-12-12');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Bone', 'Bath', '2013-11-08');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Garwin', 'Suddell', '2017-12-29');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Margery', 'Slowgrove', '2019-12-16');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Shayne', 'Dybell', '2007-11-15');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Angil', 'Cane', '2019-09-15');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Kimberlee', 'Asker', '2016-04-10');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Nike', 'Bonin', '2013-10-18');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Claudius', 'Town', '2011-11-07');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Donetta', 'Prue', '2019-07-19');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Kata', 'Hansill', '2010-11-17');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Mal', 'Berr', '2020-06-11');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Arnuad', 'Waren', '2013-09-04');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Fleurette', 'Cunrado', '2009-07-24');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Melita', 'Jakab', '2015-06-15');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Anissa', 'Dancer', '2008-06-13');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Helyn', 'Smalecombe', '2009-05-10');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Gard', 'Crowe', '2017-12-30');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Birk', 'Bishopp', '2014-04-19');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Erena', 'Revely', '2019-12-12');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Dennis', 'Southers', '2016-04-16');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Franklin', 'Van Daalen', '2014-08-27');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Jorge', 'Pillington', '2012-11-16');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Melva', 'Bernt', '2013-08-04');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Codee', 'O'' Dooley', '2015-11-24');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Petr', 'Rickcord', '2011-01-19');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Raviv', 'Wenban', '2014-06-14');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Yoshiko', 'Hegge', '2013-11-21');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Hayley', 'Searight', '2019-02-05');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Leslie', 'Priddey', '2013-01-19');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Jelene', 'Barnicott', '2009-02-28');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Evin', 'Brocking', '2007-05-25');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Deonne', 'Sterzaker', '2020-01-03');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Deloria', 'Tal', '2015-08-03');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Babette', 'Lindelof', '2010-08-14');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Concettina', 'Parsons', '2009-05-09');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Shepperd', 'Klemmt', '2020-05-20');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Mord', 'Leary', '2018-07-22');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Araldo', 'Smart', '2010-02-23');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Arda', 'Pavelin', '2007-07-06');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Yvette', 'O''Nion', '2017-07-11');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Krista', 'Kilbourne', '2010-02-04');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Diarmid', 'Boulter', '2011-12-02');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Berkie', 'Howford', '2011-05-19');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Cloris', 'Esland', '2015-09-19');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Beilul', 'Gledhall', '2014-03-05');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Deerdre', 'Dawbury', '2012-06-13');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Deirdre', 'Leak', '2017-07-07');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Andrey', 'Ruhben', '2018-12-24');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Zachery', 'Briggdale', '2010-05-01');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Libbey', 'Wareing', '2017-02-17');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Dasi', 'Ladewig', '2020-06-06');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Georgie', 'Sauter', '2013-10-13');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Stanislaw', 'Jehan', '2013-02-05');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Donella', 'Kinforth', '2013-04-29');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Lefty', 'Parrett', '2019-04-25');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Baron', 'Swigg', '2010-10-23');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Ludovico', 'Saket', '2018-04-17');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Dorothea', 'Meyer', '2013-09-21');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Dionne', 'Beecraft', '2011-11-06');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Patin', 'Winch', '2008-05-24');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Salaidh', 'Nolton', '2018-02-10');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Lanny', 'Danielsen', '2015-06-09');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Yettie', 'Tomkys', '2016-12-01');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Opaline', 'Pagram', '2015-02-04');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Bastien', 'Crass', '2013-06-21');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Noach', 'Sheahan', '2016-04-23');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Brittan', 'Cockayme', '2017-09-11');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Hermine', 'McKinna', '2020-06-08');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Thom', 'Warrillow', '2011-06-29');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Oriana', 'Rookeby', '2009-12-12');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Christian', 'Silman', '2014-11-05');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Pammie', 'Gadman', '2009-09-18');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Danit', 'Kembry', '2007-11-02');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Nerti', 'Tatershall', '2019-05-04');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Andros', 'Hariot', '2018-04-06');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Alena', 'Santon', '2012-10-11');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Karlis', 'Hagstone', '2008-08-28');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Donall', 'Kingsnode', '2009-08-30');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Brandy', 'Paler', '2017-07-01');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Rosanne', 'Redhills', '2020-07-07');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Frazier', 'Caser', '2017-11-26');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Janna', 'Brinsden', '2019-12-18');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Johanna', 'McTavish', '2017-08-14');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Marylou', 'D''Ambrosi', '2012-02-04');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Colly', 'Sazio', '2019-06-09');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Fletcher', 'Sharp', '2013-01-20');
insert into personas_mock (nombre, apellido, fechaNacimiento) values ('Nehemiah', 'Walmsley', '2012-06-28');

--- muestra entre las fechas determinadas
select * from personas_mock where fechaNacimiento between '2012-01-05' and '2020-10-23'
--- otra opcion
select * from personas_mock where fechaNacimiento >= '2012-01-05' and fechaNacimiento <='2020-10-23'

--- ordenar por fecha
select * from personas_mock order by fechaNacimiento ASC

---trae los que son distintos
select distinct apellido from personas_mock

--muestra top
select top(3) nombre from personas_mock

--max y min
select max(fechaNacimiento) as maximo from personas_mock
select min(fechaNacimiento) as minimo from personas_mock

--
select count(distinct fechaNacimiento) cuenta from personas_mock
