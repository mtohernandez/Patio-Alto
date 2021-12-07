CREATE DATABASE HIGHGARDEN

USE HIGHGARDEN

CREATE TABLE vuelos(
	vuelos_id VARCHAR(20), --PRIMARY KEY 
	destino_vuelo VARCHAR(20),
	origen_vuelo VARCHAR(20),
	puestos_disponibles INT,
	hora_de_salida TIME,
	estado_del_vuelo VARCHAR(10)
);

CREATE TABLE pasajeros(
	pasajero_id INT,
	vuelo_id VARCHAR(20), -- FOREIGN KEY
	estado_pasajero VARCHAR(10),
	nombre_pasajero VARCHAR(20),
	apellido_pasajero VARCHAR(20),
	edad_pasajero INT,
	correo_electronico_pasajero VARCHAR(40)
);

CREATE TABLE usuarios(
	username VARCHAR(20),
	password_ VARCHAR(20)
);

INSERT INTO pasajeros VALUES(1113,1001,'NORMAL', 'Mateo', 'Hernandez',19, 'tew@gmail.com')

INSERT INTO vuelos VALUES('1000', 

select * from vuelos

select * from pasajeros

delete from usuarios where username= 'mateo' and password_='123'

UPDATE vuelos
SET max_capacidad = 25
where vuelos_id = '1001';

ALTER TABLE vuelos
ALTER COLUMN estado_del_vuelo VARCHAR(20);

ALTER TABLE vuelos
ADD max_capacidad INT;