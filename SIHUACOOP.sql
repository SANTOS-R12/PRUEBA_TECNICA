USE [SIHUACOOP]
GO
/****** Object:  Table [dbo].[CLIENTE]    Script Date: 1/8/2023 02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTE](
	[no_dui] [int] NOT NULL,
	[Nombre] [char](60) NULL,
	[Telefono] [char](9) NULL,
PRIMARY KEY CLUSTERED 
(
	[no_dui] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CLIENTE] ([no_dui], [Nombre], [Telefono]) VALUES (34567890, N'SANTOS                                                      ', N'34567890 ')
INSERT [dbo].[CLIENTE] ([no_dui], [Nombre], [Telefono]) VALUES (45789631, N'MARVIN                                                      ', N'70248887 ')
INSERT [dbo].[CLIENTE] ([no_dui], [Nombre], [Telefono]) VALUES (56891245, N'ALEXANDER                                                   ', N'78855663 ')
INSERT [dbo].[CLIENTE] ([no_dui], [Nombre], [Telefono]) VALUES (89784512, N'RUIZ                                                        ', N'2565236  ')
GO
