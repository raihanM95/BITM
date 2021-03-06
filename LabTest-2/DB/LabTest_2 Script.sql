USE [LabTest_2]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 6/23/2019 5:18:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[OpeningDate] [varchar](50) NULL,
	[AccountNumber] [int] NULL,
	[Balance] [int] NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([ID], [Name], [Email], [OpeningDate], [AccountNumber], [Balance]) VALUES (1, N'Raihan', N'r@gmail.com', N'23/06/2019', 12345678, 50)
INSERT [dbo].[Customers] ([ID], [Name], [Email], [OpeningDate], [AccountNumber], [Balance]) VALUES (2, N'Rahat', N'r@gmail.com', N'23/06/2019', 15678901, NULL)
INSERT [dbo].[Customers] ([ID], [Name], [Email], [OpeningDate], [AccountNumber], [Balance]) VALUES (3, N'Jami', N'j@gmail.com', N'26/06/2019', 12346781, NULL)
SET IDENTITY_INSERT [dbo].[Customers] OFF
