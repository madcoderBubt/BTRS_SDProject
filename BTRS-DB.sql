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

