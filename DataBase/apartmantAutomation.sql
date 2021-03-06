USE [ApartmantAutomation]
GO
/****** Object:  Table [dbo].[tblExpenses]    Script Date: 8.01.2019 14:31:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblExpenses](
	[ExpenseID] [int] NOT NULL,
	[Date] [date] NULL CONSTRAINT [DF_Expenses_Date]  DEFAULT (getdate()),
	[Amount] [decimal](18, 2) NULL,
	[ExpenseType] [int] NULL,
 CONSTRAINT [PK_Expenses] PRIMARY KEY CLUSTERED 
(
	[ExpenseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblExpenseTypes]    Script Date: 8.01.2019 14:31:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblExpenseTypes](
	[TypeID] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [nvarchar](50) NULL,
 CONSTRAINT [PK_ExpenseTypes] PRIMARY KEY CLUSTERED 
(
	[TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblIncomes]    Script Date: 8.01.2019 14:31:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblIncomes](
	[IncomeID] [int] IDENTITY(1,1) NOT NULL,
	[Amount] [decimal](18, 2) NULL,
	[Date] [date] NULL CONSTRAINT [DF_Gelirler_Tarih]  DEFAULT (getdate()),
	[RoomNo] [int] NULL,
 CONSTRAINT [PK_Gelirler] PRIMARY KEY CLUSTERED 
(
	[IncomeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblRooms]    Script Date: 8.01.2019 14:31:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRooms](
	[RommID] [int] IDENTITY(1,1) NOT NULL,
	[Floor] [int] NULL,
	[RoomOwner] [nvarchar](50) NULL,
 CONSTRAINT [PK_Daireler] PRIMARY KEY CLUSTERED 
(
	[RommID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[tblExpenses] ([ExpenseID], [Date], [Amount], [ExpenseType]) VALUES (0, CAST(N'2019-01-08' AS Date), CAST(10.00 AS Decimal(18, 2)), 1)
SET IDENTITY_INSERT [dbo].[tblExpenseTypes] ON 

INSERT [dbo].[tblExpenseTypes] ([TypeID], [TypeName]) VALUES (1, N'Elektrik')
INSERT [dbo].[tblExpenseTypes] ([TypeID], [TypeName]) VALUES (2, N'Su')
INSERT [dbo].[tblExpenseTypes] ([TypeID], [TypeName]) VALUES (3, N'Asansör')
INSERT [dbo].[tblExpenseTypes] ([TypeID], [TypeName]) VALUES (4, N'Temizlik')
SET IDENTITY_INSERT [dbo].[tblExpenseTypes] OFF
SET IDENTITY_INSERT [dbo].[tblIncomes] ON 

INSERT [dbo].[tblIncomes] ([IncomeID], [Amount], [Date], [RoomNo]) VALUES (2, CAST(100.00 AS Decimal(18, 2)), CAST(N'2019-01-08' AS Date), 1)
INSERT [dbo].[tblIncomes] ([IncomeID], [Amount], [Date], [RoomNo]) VALUES (3, CAST(1.00 AS Decimal(18, 2)), CAST(N'2019-01-08' AS Date), 1)
SET IDENTITY_INSERT [dbo].[tblIncomes] OFF
SET IDENTITY_INSERT [dbo].[tblRooms] ON 

INSERT [dbo].[tblRooms] ([RommID], [Floor], [RoomOwner]) VALUES (1, 1, N'1')
SET IDENTITY_INSERT [dbo].[tblRooms] OFF
ALTER TABLE [dbo].[tblExpenses]  WITH CHECK ADD  CONSTRAINT [FK_Expenses_ExpenseTypes] FOREIGN KEY([ExpenseType])
REFERENCES [dbo].[tblExpenseTypes] ([TypeID])
GO
ALTER TABLE [dbo].[tblExpenses] CHECK CONSTRAINT [FK_Expenses_ExpenseTypes]
GO
ALTER TABLE [dbo].[tblIncomes]  WITH CHECK ADD  CONSTRAINT [FK_Incomes_Rooms] FOREIGN KEY([RoomNo])
REFERENCES [dbo].[tblRooms] ([RommID])
GO
ALTER TABLE [dbo].[tblIncomes] CHECK CONSTRAINT [FK_Incomes_Rooms]
GO
