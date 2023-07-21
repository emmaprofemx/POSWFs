CREATE PROCEDURE ActualizarFacturas @CodigoCliente int
	
AS
BEGIN
	declare @NumeroFactura int 

	select @NumeroFactura = MAX(@NumeroFactura) from Facturas

	if @NumeroFactura is null set @NumeroFactura = 0
	set @NumeroFactura = @NumeroFactura+1

	INSERT into Facturas (NumeroFactura , FechaFactura , CodigoCliente) values (@NumeroFactura , GETDATE(),@CodigoCliente)

	SELECT * FROM Facturas where NumeroFactura = @NumeroFactura
END
GO
