CREATE PROCEDURE sp_EliminarProductos	

@id_producto int

AS
BEGIN
	delete from Articulos where id_producto = @id_producto
END
GO
