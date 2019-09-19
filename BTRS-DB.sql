-- Create a new database called 'BTRS_db'
-- Connect to the 'master' database to run this snippet
USE master
GO
-- Create the new database if it does not exist already
IF NOT EXISTS (
    SELECT name
        FROM sys.databases
        WHERE name = N'BTRS_db'
)
CREATE DATABASE BTRS_db
GO

USE BTRS_db
Go

CREATE TABLE [dbo].[Bus_Type] (
    [id]   INT          IDENTITY (1, 1) NOT NULL,
    [type] VARCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);
Go

CREATE TABLE [dbo].[Bus] (
    [no]             CHAR (5) NOT NULL,
    [type]           INT      NULL,
    [total_capacity] INT      NULL,
    [avail_seat]     INT      NULL,
    PRIMARY KEY CLUSTERED ([no] ASC),
    FOREIGN KEY ([type]) REFERENCES [dbo].[Bus_Type] ([id])
);
Go

CREATE TABLE [dbo].[counter] (
    [name]     VARCHAR (10) NOT NULL,
    [location] VARCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([name] ASC)
);
Go

CREATE TABLE [dbo].[Bus_Counter] (
    [counter_name] VARCHAR (10) NOT NULL,
    [bus_no]       CHAR (5)     NOT NULL,
    [date]         DATE         NULL,
    [time]         TIME (7)     NULL,
    PRIMARY KEY CLUSTERED ([counter_name] ASC, [bus_no] ASC),
    FOREIGN KEY ([counter_name]) REFERENCES [dbo].[counter] ([name]),
    FOREIGN KEY ([bus_no]) REFERENCES [dbo].[Bus] ([no])
);
Go

CREATE TABLE [dbo].[Passenger] (
    [ticket_no]   INT          NOT NULL,
    [full_name]   VARCHAR (20) NULL,
    [phone_no]    CHAR (11)    NULL,
    [bus_no]      CHAR (5)     NOT NULL,
    [start_loc]   VARCHAR (10) NULL,
    [end_loc]     VARCHAR (10) NULL,
    [seat_length] INT          NULL,
    [counter]     VARCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([ticket_no] ASC, [bus_no] ASC, [counter] ASC),
    FOREIGN KEY ([counter]) REFERENCES [dbo].[counter] ([name]),
    FOREIGN KEY ([bus_no]) REFERENCES [dbo].[Bus] ([no])
);
Go

CREATE TABLE [dbo].[Role] (
    [id]   INT          IDENTITY (1, 1) NOT NULL,
    [name] VARCHAR (15) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);
Go

CREATE TABLE [dbo].[User] (
    [user_id]   INT          IDENTITY (1, 1) NOT NULL,
    [full_name] VARCHAR (20) NULL,
    [password]  VARCHAR (20) NULL,
    [phone_no]  CHAR (11)    NULL,
    [counter]   VARCHAR (10) NULL,
    [role]      INT          NULL,
    PRIMARY KEY CLUSTERED ([user_id] ASC),
    FOREIGN KEY ([counter]) REFERENCES [dbo].[counter] ([name]),
    FOREIGN KEY ([role]) REFERENCES [dbo].[Role] ([id])
);
Go
