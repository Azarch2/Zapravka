USE [Zapravka]
GO
/****** Object:  Table [dbo].[Automobile]    Script Date: 15.11.2022 13:34:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Automobile](
	[TankVolume] [float] NOT NULL,
	[MaxTankVolume] [float] NOT NULL,
	[Mark] [varchar](50) NULL,
	[Model] [varchar](50) NULL,
	[Id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Banknote]    Script Date: 15.11.2022 13:34:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Banknote](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [int] NOT NULL,
	[BanknoteTypeId] [int] NOT NULL,
	[ClientId] [int] NOT NULL,
 CONSTRAINT [PK_Banknote] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BanknoteType]    Script Date: 15.11.2022 13:34:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BanknoteType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Price] [money] NOT NULL,
 CONSTRAINT [PK_BanknoteType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 15.11.2022 13:34:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[TotalBalance] [money] NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gasoline]    Script Date: 15.11.2022 13:34:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gasoline](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StationId] [int] NOT NULL,
 CONSTRAINT [PK_Gasoline] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PetrolType]    Script Date: 15.11.2022 13:34:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PetrolType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[GasolineId] [int] NOT NULL,
 CONSTRAINT [PK_PetrolType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Station]    Script Date: 15.11.2022 13:34:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Station](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [int] NOT NULL,
 CONSTRAINT [PK_Station] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Automobile] ([TankVolume], [MaxTankVolume], [Mark], [Model], [Id]) VALUES (71, 85, N'Mercedes', N'AMG GT 63 S', 6)
GO
SET IDENTITY_INSERT [dbo].[Banknote] ON 

INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (1, 5456, 1, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (2, 5457, 1, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (3, 5458, 1, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (4, 5459, 1, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (5, 5460, 1, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (6, 5461, 1, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (7, 5462, 1, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (9, 1002, 2, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (10, 1003, 2, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (11, 1004, 2, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (12, 1005, 2, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (13, 1006, 2, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (14, 1007, 2, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (15, 1008, 2, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (16, 1009, 2, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (17, 1010, 2, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (18, 1011, 2, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (19, 1012, 2, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (22, 2003, 3, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (23, 2004, 3, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (24, 2005, 3, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (25, 2006, 3, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (26, 2007, 3, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (27, 2008, 3, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (28, 2009, 3, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (29, 2010, 3, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (30, 2011, 3, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (31, 2012, 3, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (35, 3004, 4, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (36, 3005, 4, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (37, 3006, 4, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (38, 3007, 4, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (39, 3008, 4, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (40, 3009, 4, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (41, 3010, 4, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (42, 3011, 4, 6)
INSERT [dbo].[Banknote] ([Id], [Number], [BanknoteTypeId], [ClientId]) VALUES (43, 3012, 4, 6)
SET IDENTITY_INSERT [dbo].[Banknote] OFF
GO
SET IDENTITY_INSERT [dbo].[BanknoteType] ON 

INSERT [dbo].[BanknoteType] ([Id], [Price]) VALUES (1, 1000.0000)
INSERT [dbo].[BanknoteType] ([Id], [Price]) VALUES (2, 500.0000)
INSERT [dbo].[BanknoteType] ([Id], [Price]) VALUES (3, 100.0000)
INSERT [dbo].[BanknoteType] ([Id], [Price]) VALUES (4, 50.0000)
SET IDENTITY_INSERT [dbo].[BanknoteType] OFF
GO
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([Id], [Login], [Name], [TotalBalance]) VALUES (4, N'FirstClient', N'Михаил', NULL)
INSERT [dbo].[Client] ([Id], [Login], [Name], [TotalBalance]) VALUES (5, N'SecondClient', N'Григорий', NULL)
INSERT [dbo].[Client] ([Id], [Login], [Name], [TotalBalance]) VALUES (6, N'ThirdClient', N'Вадим', NULL)
SET IDENTITY_INSERT [dbo].[Client] OFF
GO
SET IDENTITY_INSERT [dbo].[Gasoline] ON 

INSERT [dbo].[Gasoline] ([Id], [StationId]) VALUES (1, 1)
INSERT [dbo].[Gasoline] ([Id], [StationId]) VALUES (2, 1)
INSERT [dbo].[Gasoline] ([Id], [StationId]) VALUES (3, 2)
INSERT [dbo].[Gasoline] ([Id], [StationId]) VALUES (4, 2)
INSERT [dbo].[Gasoline] ([Id], [StationId]) VALUES (5, 3)
INSERT [dbo].[Gasoline] ([Id], [StationId]) VALUES (6, 3)
INSERT [dbo].[Gasoline] ([Id], [StationId]) VALUES (7, 1)
SET IDENTITY_INSERT [dbo].[Gasoline] OFF
GO
SET IDENTITY_INSERT [dbo].[PetrolType] ON 

INSERT [dbo].[PetrolType] ([Id], [Name], [GasolineId]) VALUES (1, N'95', 1)
INSERT [dbo].[PetrolType] ([Id], [Name], [GasolineId]) VALUES (2, N'92', 2)
INSERT [dbo].[PetrolType] ([Id], [Name], [GasolineId]) VALUES (3, N'95', 3)
INSERT [dbo].[PetrolType] ([Id], [Name], [GasolineId]) VALUES (4, N'92', 4)
INSERT [dbo].[PetrolType] ([Id], [Name], [GasolineId]) VALUES (5, N'95', 5)
INSERT [dbo].[PetrolType] ([Id], [Name], [GasolineId]) VALUES (6, N'92', 6)
INSERT [dbo].[PetrolType] ([Id], [Name], [GasolineId]) VALUES (7, N'95', 7)
SET IDENTITY_INSERT [dbo].[PetrolType] OFF
GO
SET IDENTITY_INSERT [dbo].[Station] ON 

INSERT [dbo].[Station] ([Id], [Number]) VALUES (1, 1)
INSERT [dbo].[Station] ([Id], [Number]) VALUES (2, 2)
INSERT [dbo].[Station] ([Id], [Number]) VALUES (3, 3)
INSERT [dbo].[Station] ([Id], [Number]) VALUES (4, 4)
SET IDENTITY_INSERT [dbo].[Station] OFF
GO
ALTER TABLE [dbo].[Automobile]  WITH CHECK ADD FOREIGN KEY([Id])
REFERENCES [dbo].[Client] ([Id])
GO
ALTER TABLE [dbo].[Banknote]  WITH CHECK ADD  CONSTRAINT [FK_Banknote_BanknoteType] FOREIGN KEY([BanknoteTypeId])
REFERENCES [dbo].[BanknoteType] ([Id])
GO
ALTER TABLE [dbo].[Banknote] CHECK CONSTRAINT [FK_Banknote_BanknoteType]
GO
ALTER TABLE [dbo].[Banknote]  WITH CHECK ADD  CONSTRAINT [FK_Banknote_Client] FOREIGN KEY([ClientId])
REFERENCES [dbo].[Client] ([Id])
GO
ALTER TABLE [dbo].[Banknote] CHECK CONSTRAINT [FK_Banknote_Client]
GO
ALTER TABLE [dbo].[Gasoline]  WITH CHECK ADD  CONSTRAINT [FK_Gasoline_Station] FOREIGN KEY([StationId])
REFERENCES [dbo].[Station] ([Id])
GO
ALTER TABLE [dbo].[Gasoline] CHECK CONSTRAINT [FK_Gasoline_Station]
GO
ALTER TABLE [dbo].[PetrolType]  WITH CHECK ADD  CONSTRAINT [FK_PetrolType_Gasoline] FOREIGN KEY([GasolineId])
REFERENCES [dbo].[Gasoline] ([Id])
GO
ALTER TABLE [dbo].[PetrolType] CHECK CONSTRAINT [FK_PetrolType_Gasoline]
GO
