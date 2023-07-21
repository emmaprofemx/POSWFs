CREATE PROCEDURE ActualizarDetalles @NumeroFactura int , @CodigoProducto int , @PrecioVenta float , @CantidadVendida float
	
AS
BEGIN
	INSERT into Detalles(NumeroFactura , CodigoProducto , PrecioVenta , CantidadVendida) VALUES (@NumeroFactura  , @CodigoProducto  , @PrecioVenta  , @CantidadVendida )
END
GO
