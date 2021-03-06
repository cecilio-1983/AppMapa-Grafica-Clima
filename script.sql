
/****** Object:  Table [dbo].[puntos_de_interes]    Script Date: 26/04/2021 12:36:53******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[puntos_de_interes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Latitud] [decimal](9, 6) NOT NULL,
	[Longitud] [decimal](9, 6) NOT NULL,
	[Descripcion] [varchar](500) NOT NULL,
	[Venta] [decimal](14, 2) NOT NULL,
	[Idzona] [int] NULL,
 CONSTRAINT [PK_puntos_de_interes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zonas]    Script Date: 26/04/2021 12:36:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zonas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](500) NOT NULL,
 CONSTRAINT [PK_Zonas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[puntos_de_interes] ON 

INSERT [dbo].[puntos_de_interes] ([Id], [Latitud], [Longitud], [Descripcion], [Venta], [Idzona]) VALUES (2, CAST(19.580940 AS Decimal(9, 6)), CAST(-99.254057 AS Decimal(9, 6)), N'centro comercial', CAST(108990.56 AS Decimal(14, 2)), 3)
INSERT [dbo].[puntos_de_interes] ([Id], [Latitud], [Longitud], [Descripcion], [Venta], [Idzona]) VALUES (5, CAST(19.587685 AS Decimal(9, 6)), CAST(-99.267069 AS Decimal(9, 6)), N'Interes Cambio', CAST(35678.00 AS Decimal(14, 2)), 5)
INSERT [dbo].[puntos_de_interes] ([Id], [Latitud], [Longitud], [Descripcion], [Venta], [Idzona]) VALUES (6, CAST(19.581264 AS Decimal(9, 6)), CAST(-99.244874 AS Decimal(9, 6)), N'Teatro Zaragoza', CAST(100000.00 AS Decimal(14, 2)), 5)
INSERT [dbo].[puntos_de_interes] ([Id], [Latitud], [Longitud], [Descripcion], [Venta], [Idzona]) VALUES (7, CAST(19.581264 AS Decimal(9, 6)), CAST(-99.244874 AS Decimal(9, 6)), N'Buenavista', CAST(123478.00 AS Decimal(14, 2)), 4)
INSERT [dbo].[puntos_de_interes] ([Id], [Latitud], [Longitud], [Descripcion], [Venta], [Idzona]) VALUES (12, CAST(19.587674 AS Decimal(9, 6)), CAST(-99.240438 AS Decimal(9, 6)), N'San jun Ixtacala', CAST(8898989.67 AS Decimal(14, 2)), 7)
INSERT [dbo].[puntos_de_interes] ([Id], [Latitud], [Longitud], [Descripcion], [Venta], [Idzona]) VALUES (13, CAST(19.589653 AS Decimal(9, 6)), CAST(-99.235278 AS Decimal(9, 6)), N'Pizas Lindas', CAST(4500089.00 AS Decimal(14, 2)), 8)
INSERT [dbo].[puntos_de_interes] ([Id], [Latitud], [Longitud], [Descripcion], [Venta], [Idzona]) VALUES (15, CAST(19.589653 AS Decimal(9, 6)), CAST(-99.235278 AS Decimal(9, 6)), N'Herrería y Vidirio Caracol', CAST(350000.00 AS Decimal(14, 2)), 3)
INSERT [dbo].[puntos_de_interes] ([Id], [Latitud], [Longitud], [Descripcion], [Venta], [Idzona]) VALUES (18, CAST(19.589653 AS Decimal(9, 6)), CAST(-99.235278 AS Decimal(9, 6)), N'El cerrito', CAST(1456700.00 AS Decimal(14, 2)), 4)
INSERT [dbo].[puntos_de_interes] ([Id], [Latitud], [Longitud], [Descripcion], [Venta], [Idzona]) VALUES (20, CAST(19.589653 AS Decimal(9, 6)), CAST(-99.235278 AS Decimal(9, 6)), N'La colmena', CAST(100000.00 AS Decimal(14, 2)), 7)
INSERT [dbo].[puntos_de_interes] ([Id], [Latitud], [Longitud], [Descripcion], [Venta], [Idzona]) VALUES (21, CAST(19.586684 AS Decimal(9, 6)), CAST(-99.243361 AS Decimal(9, 6)), N'ISRTY', CAST(64566689.00 AS Decimal(14, 2)), 3)
SET IDENTITY_INSERT [dbo].[puntos_de_interes] OFF
GO
SET IDENTITY_INSERT [dbo].[Zonas] ON 

INSERT [dbo].[Zonas] ([Id], [Descripcion]) VALUES (3, N'Norte')
INSERT [dbo].[Zonas] ([Id], [Descripcion]) VALUES (4, N'Sur')
INSERT [dbo].[Zonas] ([Id], [Descripcion]) VALUES (5, N'Suroeste')
INSERT [dbo].[Zonas] ([Id], [Descripcion]) VALUES (7, N'Este')
INSERT [dbo].[Zonas] ([Id], [Descripcion]) VALUES (8, N'Oeste')
SET IDENTITY_INSERT [dbo].[Zonas] OFF
GO
ALTER TABLE [dbo].[puntos_de_interes]  WITH CHECK ADD  CONSTRAINT [fk_puntos_de_interes_Zona] FOREIGN KEY([Idzona])
REFERENCES [dbo].[Zonas] ([Id])
GO
ALTER TABLE [dbo].[puntos_de_interes] CHECK CONSTRAINT [fk_puntos_de_interes_Zona]
GO
