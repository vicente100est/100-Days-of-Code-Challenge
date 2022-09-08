
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter PROCEDURE spEliminarVendedor 
	@idVendedor int
AS
BEGIN
	declare @idVendedorDestino int
	declare @CantidadVendedoresPosibles int = (select count(*) from vendedor where id != @idVendedor)
	
	--validamos que existe vendedor a transferir
	if(select count(*) from vendedor where id = @idVendedor) > 0
		begin
			if(@CantidadVendedoresPosibles > 0)
				begin
					--obtenemos vendedor destino
					set @idVendedorDestino = (select top(1) id from vendedor where id != @idVendedor)

					--Transferimos los clientes al vendedor destino
					update cliente set idVendedor = @idVendedorDestino where idVendedor = @idVendedor

					--Eliminamos vendedor que recibimos
					delete vendedor where id = @idVendedor
				end
			else
				begin
					select 'No existen vendedores para transferir los clientes'
				end
		end
	else
		begin
			select 'Fatal Error: El vendedor no existe'
		end
END
GO
