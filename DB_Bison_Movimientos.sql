use Administracion
 -- Inventario
 Create Table Invetario (
 Id int identity primary key not null,
 Producto nvarchar(250) not null,
 Categoria nvarchar(250) not null,
 Precio float not null,
 Cantidad int not null,
 Codigo nvarchar(50) not null
 );

 -- Clientes
 Create Table Clientes (
 ID int identity primary key,
 Nombre Nvarchar(150),
 Apellido Nvarchar(150),
 Telefono Nvarchar(150),
 Correo Nvarchar(150),
 Codigo Nvarchar(150),
 Descuento float,
 CantCompras int
 );

 -- Facturas

 Create Table Facturacion (
 Id int identity primary key,
 Codigo Nvarchar(250),
 Producto Nvarchar(250),
 PrecioxUnidad float,
 Cantidad int,
 Cliente Nvarchar(250),
 CodigoCliente Nvarchar(250),
 DescuentoCliente float,
 MontoTotal float
 )

 Alter Table Facturacion
 add [PrecioTotal] as (PrecioxUnidad * Cantidad)

