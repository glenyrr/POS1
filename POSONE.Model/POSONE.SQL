
GO
CREATE TABLE [dbo].[Articulo](
	[Id] [varchar](50) NOT NULL,
	[Descripcion] [nvarchar](25) NOT NULL,
	[DescripcionLarga] [nvarchar](50) NOT NULL,
	[MarcaId] [int] NOT NULL,
	[CategoriaId] [int] NOT NULL,
	[TipoId] [int] NOT NULL,
	[UMId] [int] NOT NULL,
	[IsvId] [int] NOT NULL,
	[IncluyeImpuesto] [bit] NOT NULL,
	[CostoPromedio] [decimal](16, 2) NOT NULL,
	[PrecioVenta] [decimal](16, 2) NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Articulo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 5/10/2017 5:58:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categoria](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
 CONSTRAINT [PK_CategoriaArticulo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 5/10/2017 5:58:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[ClienteId] [int] IDENTITY(1,1) NOT NULL,
	[Cliente] [nvarchar](100) NULL,
	[RtnCliente] [nvarchar](50) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[ClienteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EscalaPrecioVenta]    Script Date: 5/10/2017 5:58:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EscalaPrecioVenta](
	[ArticuloId] [varchar](50) NOT NULL,
	[EscalaInicio] [decimal](16, 2) NOT NULL,
	[EscalaFinal] [decimal](16, 2) NOT NULL,
	[Precio] [decimal](16, 2) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FacturaVenta]    Script Date: 5/10/2017 5:58:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FacturaVenta](
	[Factura] [varchar](80) NOT NULL,
	[FacturaTipo] [nvarchar](50) NOT NULL,
	[ClienteId] [int] NULL,
	[Cliente] [nvarchar](100) NULL,
	[RtnCliente] [nvarchar](50) NULL,
	[CajaId] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Estado] [nvarchar](20) NOT NULL,
	[UsuarioId] [nvarchar](50) NOT NULL,
	[Recibido] [decimal](16, 2) NOT NULL,
	[Cambio] [decimal](16, 2) NOT NULL,
	[ClienteFrecuenteId] [nvarchar](50) NULL,
	[EnCierre] [bit] NOT NULL,
 CONSTRAINT [PK_FacturaVenta] PRIMARY KEY CLUSTERED 
(
	[Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ISV]    Script Date: 5/10/2017 5:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ISV](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](20) NULL,
	[IsvPorcentaje] [decimal](16, 2) NULL,
 CONSTRAINT [PK_ISV] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Marca]    Script Date: 5/10/2017 5:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Marca](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Marca] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tipo]    Script Date: 5/10/2017 5:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tipo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
 CONSTRAINT [PK_TipoArticulo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UnidadMedida]    Script Date: 5/10/2017 5:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UnidadMedida](
	[Id] [int] NOT NULL,
	[Codigo] [varchar](5) NOT NULL,
	[Nombre] [varchar](50) NULL,
 CONSTRAINT [PK_UnidadMedida] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Articulo] ADD  CONSTRAINT [DF_Articulo_ISVIncluido]  DEFAULT ((0)) FOR [IncluyeImpuesto]
GO
ALTER TABLE [dbo].[Articulo] ADD  CONSTRAINT [DF_Articulo_CostoPromedio]  DEFAULT ((0.00)) FOR [CostoPromedio]
GO
ALTER TABLE [dbo].[Articulo] ADD  CONSTRAINT [DF_Articulo_PrecioVenta]  DEFAULT ((0.00)) FOR [PrecioVenta]
GO
ALTER TABLE [dbo].[Articulo] ADD  CONSTRAINT [DF_Articulo_Activo]  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[FacturaVenta] ADD  CONSTRAINT [DF_FacturaVenta_FacturaTipo]  DEFAULT (N'CONTADO') FOR [FacturaTipo]
GO
ALTER TABLE [dbo].[FacturaVenta] ADD  CONSTRAINT [DF_FacturaVenta_Estado]  DEFAULT (N'ABIERTA') FOR [Estado]
GO
ALTER TABLE [dbo].[FacturaVenta] ADD  CONSTRAINT [DF_FacturaVenta_EnCierre]  DEFAULT ((0)) FOR [EnCierre]
GO
ALTER TABLE [dbo].[Articulo]  WITH CHECK ADD  CONSTRAINT [FK_Articulo_CategoriaArticulo] FOREIGN KEY([CategoriaId])
REFERENCES [dbo].[Categoria] ([Id])
GO
ALTER TABLE [dbo].[Articulo] CHECK CONSTRAINT [FK_Articulo_CategoriaArticulo]
GO
ALTER TABLE [dbo].[Articulo]  WITH CHECK ADD  CONSTRAINT [FK_Articulo_ISV] FOREIGN KEY([IsvId])
REFERENCES [dbo].[ISV] ([Id])
GO
ALTER TABLE [dbo].[Articulo] CHECK CONSTRAINT [FK_Articulo_ISV]
GO
ALTER TABLE [dbo].[Articulo]  WITH CHECK ADD  CONSTRAINT [FK_Articulo_Marca] FOREIGN KEY([MarcaId])
REFERENCES [dbo].[Marca] ([Id])
GO
ALTER TABLE [dbo].[Articulo] CHECK CONSTRAINT [FK_Articulo_Marca]
GO
ALTER TABLE [dbo].[Articulo]  WITH CHECK ADD  CONSTRAINT [FK_Articulo_TipoArticulo] FOREIGN KEY([TipoId])
REFERENCES [dbo].[Tipo] ([Id])
GO
ALTER TABLE [dbo].[Articulo] CHECK CONSTRAINT [FK_Articulo_TipoArticulo]
GO
ALTER TABLE [dbo].[Articulo]  WITH CHECK ADD  CONSTRAINT [FK_Articulo_UnidadMedida] FOREIGN KEY([UMId])
REFERENCES [dbo].[UnidadMedida] ([Id])
GO
ALTER TABLE [dbo].[Articulo] CHECK CONSTRAINT [FK_Articulo_UnidadMedida]
GO
ALTER TABLE [dbo].[EscalaPrecioVenta]  WITH CHECK ADD  CONSTRAINT [FK_EscalaPrecioVenta_Articulo] FOREIGN KEY([ArticuloId])
REFERENCES [dbo].[Articulo] ([Id])
GO
ALTER TABLE [dbo].[EscalaPrecioVenta] CHECK CONSTRAINT [FK_EscalaPrecioVenta_Articulo]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo de Articulo o Codigo de Barra' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Articulo', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descripcion del articulo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Articulo', @level2type=N'COLUMN',@level2name=N'Descripcion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descripcion larga automatica' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Articulo', @level2type=N'COLUMN',@level2name=N'DescripcionLarga'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Marca ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Articulo', @level2type=N'COLUMN',@level2name=N'MarcaId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Determina la Categoria del Articulo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Articulo', @level2type=N'COLUMN',@level2name=N'CategoriaId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Determina el Tipo de Articulo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Articulo', @level2type=N'COLUMN',@level2name=N'TipoId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Determina la unidad de medida (UM) de compra del articulo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Articulo', @level2type=N'COLUMN',@level2name=N'UMId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Determina el tipo de impuesto EXCENTO, NORMAL, LICOR' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Articulo', @level2type=N'COLUMN',@level2name=N'IsvId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Determina si el impuesto se incluye en el precio de venta' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Articulo', @level2type=N'COLUMN',@level2name=N'IncluyeImpuesto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Costo Promedio Registrado en Inventario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Articulo', @level2type=N'COLUMN',@level2name=N'CostoPromedio'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Precio de Venta o Precio de Lista si el producto no tiene una escala de ventas' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Articulo', @level2type=N'COLUMN',@level2name=N'PrecioVenta'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Almacena el catalogo de articulos' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Articulo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Almacena la Cateogia a la que pertenece un articulo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Categoria'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id del cliente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Cliente', @level2type=N'COLUMN',@level2name=N'ClienteId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre del cliente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Cliente', @level2type=N'COLUMN',@level2name=N'Cliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'RTN Cliente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Cliente', @level2type=N'COLUMN',@level2name=N'RtnCliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Escala de Prescios de Venta de Articulos' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EscalaPrecioVenta'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tipo de Factura CONTADO o CREDITO' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FacturaVenta', @level2type=N'COLUMN',@level2name=N'FacturaTipo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Almacena el Nombre del Cliente al que se factura' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FacturaVenta', @level2type=N'COLUMN',@level2name=N'Cliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Almacena el RTN del cliente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FacturaVenta', @level2type=N'COLUMN',@level2name=N'RtnCliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Almacena el Id de la CAJA donde se cobro la factura' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FacturaVenta', @level2type=N'COLUMN',@level2name=N'CajaId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de Creacion de la factura.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FacturaVenta', @level2type=N'COLUMN',@level2name=N'Fecha'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Estado de la factura ABIERTA, COBRADA, NULA' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FacturaVenta', @level2type=N'COLUMN',@level2name=N'Estado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Usuario que crea la factura' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FacturaVenta', @level2type=N'COLUMN',@level2name=N'UsuarioId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Cantidad recibida de dinero para cancelar la factura' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FacturaVenta', @level2type=N'COLUMN',@level2name=N'Recibido'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Combio la diferencia entre lo recibido y lo cobrado' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FacturaVenta', @level2type=N'COLUMN',@level2name=N'Cambio'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Cliente frecuente persona que compra' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FacturaVenta', @level2type=N'COLUMN',@level2name=N'ClienteFrecuenteId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Almacena los Tipos de los Articulos' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tipo'
GO
USE [master]
GO
ALTER DATABASE [POS1] SET  READ_WRITE 
GO
