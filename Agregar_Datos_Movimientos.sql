use Administracion;

-- Rellenar Inventario --
set IDENTITY_INSERT Inventario on;

Insert into Inventario(Id,Producto,Categoria,Precio,Cantidad,Codigo)
Values
	(1,'Vaso Personalizado', 'Personalizados', 80,42,'PE1'),
	(2,'Termo Personalizado', 'Personalizados', 190,13,'PE2'),
	(3,'Camisa Blanca Personalizada', 'Personalizados', 152,50,'PE3'),
	(4,'Camisa Color Personalizada', 'Personalizados', 155,41,'PE4'),
	(5,'Taza Personalizada', 'Personalizados', 100,13,'PE5'),
	(6,'Libretas', 'Basicos', 12,100,'BAS01'),
	(7,'Plumas', 'Basicos', 10,70,'BAS02'),
	(8,'Paquete de Hojas (100 pzs)', 'Basicos', 87,5,'PACB1'),
	(9,'Vinil 20x50', 'Imprenta', 50,45,'MA1');

set IDENTITY_INSERT Inventario off;


-- Rellenar Clientes --

set IDENTITY_INSERT Clientes on;

Insert into Clientes(ID,Nombre,Apellido,Telefono,Correo,Codigo,Descuento,CantCompras)
Values (1,'Alan','Santiago','8124465652','alantadeo@live.com','001',0,0);

set IDENTITY_INSERT Clientes off;

