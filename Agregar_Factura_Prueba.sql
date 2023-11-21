  use Administracion;

  insert into Facturacion (Codigo,Producto,PrecioxUnidad,Cantidad,Descuento,Cliente, CodigoCliente,DescuentoCliente, MontoTotal, NumFactura ) 
  values ('PE1', 'Vaso Personalizado', 80,1,0,'Alan Santiago','001',0,80,0)


  delete from Facturacion
  where NumFactura = 1;