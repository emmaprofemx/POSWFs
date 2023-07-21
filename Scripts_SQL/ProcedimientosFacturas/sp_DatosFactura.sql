-- =============================================
-- Author:		Ruiz Garcia Emmanuel Alejandro
-- Create date: 21/07/2023
-- =============================================
CREATE PROCEDURE DatosFactura @NumeroFactura int

AS
BEGIN
	Select 
	--Obteniendo todos los campos de nuestra tabla factura , las requerimos
	--D.PrecioVenta * D.CantidadVendida as total , REALIZANDO MULTIPLICACION DE Precio * Cantidad
	F.* , D.PrecioVenta , D.CantidadVendida , C.Nombre_cliente , C.Apellido_cliente , A.Nombre_producto , D.PrecioVenta * D.CantidadVendida as total

	From 
	Facturas F 
	inner join Detalles D on F.NumeroFactura = D.NumeroFactura
	inner join Articulos A on D.CodigoProducto = A.id_producto
	inner join Clientes C on F.CodigoCliente = C.id_clientes

	Where F.NumeroFactura = @NumeroFactura

END
GO
