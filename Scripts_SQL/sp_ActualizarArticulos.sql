CREATE PROCEDURE sp_ActualizarArticulos
	-- Add the parameters for the stored procedure here
@id_producto int , @Nombre_producto varchar(50) , @Precio float
AS
BEGIN
	if NOT EXISTS (SELECT id_producto FROM Articulos WHERE id_producto = @id_producto)
	INSERT INTO Articulos(id_producto , Nombre_producto , Precio) VALUES (@id_producto , @Nombre_producto , @Precio)
	else 
	update Articulos set id_producto = @id_producto , Nombre_producto = @Nombre_producto , Precio = @Precio

END
GO
