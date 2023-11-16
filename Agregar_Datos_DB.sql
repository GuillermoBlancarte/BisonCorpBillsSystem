use Administracion;

set IDENTITY_INSERT Persona on;

Insert into Persona(id,nombre,apellidos,DNI,telefono,usuario,contrasena)
Values
	(1,'Alan Tadeo', 'Santiago Perez', '1909997','8124465652', 'Alan', 'Alan'),
	(2,'Guillermo', 'Blancarte Cordero', '1843282','8281315043', 'Guillermo', 'Guillermo'),
	(3,'Jesus Emiliano', 'Solis Zamarripa', '1951631','8125016345', 'Emiliano', 'Emiliano'),
	(4,'Luis Roberto', 'Carranza Espinoza', '2034235','81', NULL, NULL),
	(5,'Gustavo Alonso', 'Garza Ruiz', '1922732','81', NULL, NULL);

set IDENTITY_INSERT Persona off;