CREATE PROCEDURE sp_ActualizarClientes
	-- Add the parameters for the stored procedure here
@id_clientes int , @Nombre_cliente varchar(50) , @Apellido_cliente varchar(50)
AS
BEGIN
	if NOT EXISTS (SELECT id_clientes FROM Clientes WHERE id_clientes = @id_clientes)
	INSERT INTO Clientes(id_clientes , Nombre_cliente , Apellido_cliente) VALUES (@id_clientes , @Nombre_cliente , @Apellido_cliente)
	else 
	update Clientes set id_clientes = @id_clientes , Nombre_cliente = @Nombre_cliente , Apellido_cliente = @Apellido_cliente

END
GO
