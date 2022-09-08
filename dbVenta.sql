USE [SoyNuevoEnSQLServer]
GO
/****** Object:  UserDefinedFunction [dbo].[fnCorreos]    Script Date: 08/09/2022 05:19:31 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[fnCorreos]
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
/****** Object:  UserDefinedFunction [dbo].[fnMes]    Script Date: 08/09/2022 05:19:31 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[fnMes] 
(
	@a int, @b int, @ varchar(max)
)
RETURNS int
AS
BEGIN
	-- Return the result of the function
	RETURN month(getdate())

END
GO
/****** Object:  Table [dbo].[venta]    Script Date: 08/09/2022 05:19:31 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[venta](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[idCliente] [int] NOT NULL,
	[total] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_venta] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[concepto]    Script Date: 08/09/2022 05:19:32 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[concepto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idVenta] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[precio_unitario] [decimal](18, 2) NOT NULL,
	[cantidad] [int] NOT NULL,
	[importe] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_concepto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vwconceptos]    Script Date: 08/09/2022 05:19:32 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[vwconceptos]
as
select c.descripcion, v.total, c.cantidad, c.precio_unitario from venta as v
inner join concepto as c on c.idVenta = v.id
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 08/09/2022 05:19:32 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[edad] [int] NULL,
	[idVendedor] [int] NULL,
	[correo] [varchar](99) NULL,
 CONSTRAINT [PK_persona] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vendedor]    Script Date: 08/09/2022 05:19:32 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vendedor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[correo] [varchar](99) NULL,
 CONSTRAINT [PK_vendedor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[cliente]  WITH CHECK ADD  CONSTRAINT [FK_cliente_vendedor] FOREIGN KEY([idVendedor])
REFERENCES [dbo].[vendedor] ([id])
GO
ALTER TABLE [dbo].[cliente] CHECK CONSTRAINT [FK_cliente_vendedor]
GO
ALTER TABLE [dbo].[concepto]  WITH CHECK ADD  CONSTRAINT [FK_concepto_venta1] FOREIGN KEY([idVenta])
REFERENCES [dbo].[venta] ([id])
GO
ALTER TABLE [dbo].[concepto] CHECK CONSTRAINT [FK_concepto_venta1]
GO
ALTER TABLE [dbo].[venta]  WITH CHECK ADD  CONSTRAINT [FK_venta_cliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[cliente] ([id])
GO
ALTER TABLE [dbo].[venta] CHECK CONSTRAINT [FK_venta_cliente]
GO
/****** Object:  StoredProcedure [dbo].[spEliminarVendedor]    Script Date: 08/09/2022 05:19:32 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEliminarVendedor] 
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
