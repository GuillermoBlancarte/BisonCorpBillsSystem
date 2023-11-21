create database Administracion

use Administracion

create table Persona(
id int identity primary key not null,
nombre nvarchar(150),
apellidos nvarchar(150),
DNI nvarchar(150),
telefono nvarchar(150),
usuario nvarchar(150),
contrasena nvarchar(150)
)
