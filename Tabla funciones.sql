
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION fnCorreos
(	
	@opcion int
)
RETURNS @Table table(nombre varchar(50), correo varchar(99))
AS
begin
	
	if @opcion = 1
		begin
			insert into @Table(nombre, correo) select nombre, correo from vendedor
		end
	else if @opcion = 2
		begin
			insert into @Table(nombre, correo) select nombre, correo from cliente
		end
	else if @opcion = 3
		begin
			insert into @Table(nombre, correo) select nombre, correo from vendedor
			union
			select nombre, correo from cliente
		end

	RETURN
end
GO
