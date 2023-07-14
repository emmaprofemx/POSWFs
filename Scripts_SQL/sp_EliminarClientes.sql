CREATE PROCEDURE sp_EliminarClientes	

@id_clientes int

AS
BEGIN
	delete from Clientes where id_clientes = @id_clientes
END
GO
