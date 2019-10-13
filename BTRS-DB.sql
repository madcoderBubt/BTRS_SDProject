/****** Object:  Table [dbo].[Bus]    Script Date: 13-Oct-19 9:43:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bus](
	[no] [char](5) NOT NULL,
	[type] [int] NULL,
	[total_capacity] [int] NULL,
	[avail_seat] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bus_Counter]    Script Date: 13-Oct-19 9:43:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bus_Counter](
	[counter_name] [varchar](10) NOT NULL,
	[bus_no] [char](5) NOT NULL,
	[date] [date] NULL,
	[time] [time](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[counter_name] ASC,
	[bus_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bus_Type]    Script Date: 13-Oct-19 9:43:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bus_Type](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[type] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[counter]    Script Date: 13-Oct-19 9:43:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[counter](
	[name] [varchar](10) NOT NULL,
	[location] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Passenger]    Script Date: 13-Oct-19 9:43:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Passenger](
	[ticket_no] [int] NOT NULL,
	[full_name] [varchar](50) NULL,
	[phone_no] [char](15) NULL,
	[bus_no] [char](5) NOT NULL,
	[start_loc] [varchar](10) NULL,
	[end_loc] [varchar](10) NULL,
	[seat_length] [int] NULL,
	[counter] [varchar](10) NOT NULL,
	[Price] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[ticket_no] ASC,
	[bus_no] ASC,
	[counter] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 13-Oct-19 9:43:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 13-Oct-19 9:43:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[full_name] [varchar](20) NULL,
	[password] [varchar](20) NULL,
	[phone_no] [char](11) NULL,
	[counter] [varchar](10) NULL,
	[role] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Bus] ([no], [type], [total_capacity], [avail_seat]) VALUES (N'DH-01', 1, 45, 45)
GO
INSERT [dbo].[Bus] ([no], [type], [total_capacity], [avail_seat]) VALUES (N'MG-01', 5, 40, 40)
GO
INSERT [dbo].[Bus] ([no], [type], [total_capacity], [avail_seat]) VALUES (N'MG-36', 5, 50, 47)
GO
INSERT [dbo].[Bus_Counter] ([counter_name], [bus_no], [date], [time]) VALUES (N'Dhaka-1', N'DH-01', CAST(N'2019-10-25' AS Date), CAST(N'07:00:00' AS Time))
GO
INSERT [dbo].[Bus_Counter] ([counter_name], [bus_no], [date], [time]) VALUES (N'Dhaka-1', N'mg-36', CAST(N'2019-09-01' AS Date), CAST(N'13:00:00' AS Time))
GO
INSERT [dbo].[Bus_Counter] ([counter_name], [bus_no], [date], [time]) VALUES (N'Dhaka-2', N'MG-01', CAST(N'2019-11-01' AS Date), CAST(N'13:00:26' AS Time))
GO
INSERT [dbo].[Bus_Counter] ([counter_name], [bus_no], [date], [time]) VALUES (N'Faridpur-1', N'DH-01', CAST(N'2019-10-25' AS Date), CAST(N'11:00:00' AS Time))
GO
INSERT [dbo].[Bus_Counter] ([counter_name], [bus_no], [date], [time]) VALUES (N'Faridpur-1', N'mg-36', CAST(N'2019-09-01' AS Date), CAST(N'10:00:00' AS Time))
GO
INSERT [dbo].[Bus_Counter] ([counter_name], [bus_no], [date], [time]) VALUES (N'Jessore-1', N'MG-01', CAST(N'2019-11-01' AS Date), CAST(N'08:00:26' AS Time))
GO
INSERT [dbo].[Bus_Counter] ([counter_name], [bus_no], [date], [time]) VALUES (N'Jessore-1', N'mg-36', CAST(N'2019-09-01' AS Date), CAST(N'08:00:00' AS Time))
GO
INSERT [dbo].[Bus_Counter] ([counter_name], [bus_no], [date], [time]) VALUES (N'Jessore-2', N'DH-01', CAST(N'2019-10-25' AS Date), CAST(N'13:00:00' AS Time))
GO
INSERT [dbo].[Bus_Counter] ([counter_name], [bus_no], [date], [time]) VALUES (N'Khulna-1', N'DH-01', CAST(N'2019-10-25' AS Date), CAST(N'14:00:00' AS Time))
GO
INSERT [dbo].[Bus_Counter] ([counter_name], [bus_no], [date], [time]) VALUES (N'Khulna-1', N'MG-01', CAST(N'2019-11-01' AS Date), CAST(N'07:00:26' AS Time))
GO
INSERT [dbo].[Bus_Counter] ([counter_name], [bus_no], [date], [time]) VALUES (N'Khulna-1', N'MG-36', CAST(N'2019-10-01' AS Date), CAST(N'07:00:00' AS Time))
GO
INSERT [dbo].[Bus_Counter] ([counter_name], [bus_no], [date], [time]) VALUES (N'Magura-1', N'DH-01', CAST(N'2019-10-25' AS Date), CAST(N'12:00:00' AS Time))
GO
INSERT [dbo].[Bus_Counter] ([counter_name], [bus_no], [date], [time]) VALUES (N'Magura-1', N'MG-01', CAST(N'2019-11-01' AS Date), CAST(N'09:00:26' AS Time))
GO
INSERT [dbo].[Bus_Counter] ([counter_name], [bus_no], [date], [time]) VALUES (N'Magura-1', N'mg-36', CAST(N'2019-09-01' AS Date), CAST(N'09:00:00' AS Time))
GO
SET IDENTITY_INSERT [dbo].[Bus_Type] ON 
GO
INSERT [dbo].[Bus_Type] ([id], [type]) VALUES (1, N'AC ')
GO
INSERT [dbo].[Bus_Type] ([id], [type]) VALUES (5, N'non AC')
GO
SET IDENTITY_INSERT [dbo].[Bus_Type] OFF
GO
INSERT [dbo].[counter] ([name], [location]) VALUES (N'Dhaka-1', N'Dhaka')
GO
INSERT [dbo].[counter] ([name], [location]) VALUES (N'Dhaka-2', N'Dhaka')
GO
INSERT [dbo].[counter] ([name], [location]) VALUES (N'Faridpur-1', N'Faridpur')
GO
INSERT [dbo].[counter] ([name], [location]) VALUES (N'Jessore-1', N'Jessore')
GO
INSERT [dbo].[counter] ([name], [location]) VALUES (N'Jessore-2', N'Jessore')
GO
INSERT [dbo].[counter] ([name], [location]) VALUES (N'Khulna-1', N'Khulna')
GO
INSERT [dbo].[counter] ([name], [location]) VALUES (N'Magura-1', N'Magura')
GO
INSERT [dbo].[counter] ([name], [location]) VALUES (N'Magura-2', N'Magura')
GO
INSERT [dbo].[Passenger] ([ticket_no], [full_name], [phone_no], [bus_no], [start_loc], [end_loc], [seat_length], [counter], [Price]) VALUES (1, N'Mad coder', N'+8801632740075 ', N'MG-36', N'Magura-1', N'Dhaka-1', 2, N'Magura-1', CAST(8.60 AS Decimal(18, 2)))
GO
INSERT [dbo].[Passenger] ([ticket_no], [full_name], [phone_no], [bus_no], [start_loc], [end_loc], [seat_length], [counter], [Price]) VALUES (2, N'Mad coder', N'00254          ', N'MG-36', N'Magura-1', N'Faridpur-1', 1, N'Magura-1', CAST(1.30 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[Role] ON 
GO
INSERT [dbo].[Role] ([id], [name]) VALUES (1, N'Admin')
GO
INSERT [dbo].[Role] ([id], [name]) VALUES (2, N'Counter Manger')
GO
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 
GO
INSERT [dbo].[User] ([user_id], [full_name], [password], [phone_no], [counter], [role]) VALUES (1, N'Sudha', N'12345', N'01720000830', N'Magura-1', 1)
GO
INSERT [dbo].[User] ([user_id], [full_name], [password], [phone_no], [counter], [role]) VALUES (2, N'Sovon', N'1996', N'01632740075', N'Magura-2', 2)
GO
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Bus]  WITH CHECK ADD FOREIGN KEY([type])
REFERENCES [dbo].[Bus_Type] ([id])
GO
ALTER TABLE [dbo].[Bus_Counter]  WITH CHECK ADD FOREIGN KEY([bus_no])
REFERENCES [dbo].[Bus] ([no])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Bus_Counter]  WITH CHECK ADD FOREIGN KEY([counter_name])
REFERENCES [dbo].[counter] ([name])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Passenger]  WITH CHECK ADD FOREIGN KEY([bus_no])
REFERENCES [dbo].[Bus] ([no])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Passenger]  WITH CHECK ADD FOREIGN KEY([counter])
REFERENCES [dbo].[counter] ([name])
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD FOREIGN KEY([counter])
REFERENCES [dbo].[counter] ([name])
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD FOREIGN KEY([role])
REFERENCES [dbo].[Role] ([id])
GO