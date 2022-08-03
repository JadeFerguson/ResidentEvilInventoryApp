USE master

DROP DATABASE IF EXISTS Inventory
GO

CREATE DATABASE Inventory
GO

USE Inventory
GO

/**********
TABLES
***********/

CREATE TABLE UserInventory
(
		UserId			tinyint			PRIMARY KEY IDENTITY
		, Ammo			varchar(50)		NOT NULL
		, FirstAid		varchar(50)		NOT NULL
		, Fuel			varchar(50)		NOT NULL
		, Herbs			varchar(50)		NOT NULL
		, Misc			varchar(50)		NOT NULL
		, Supplements	varchar(50)		NOT NULL
		, Weapons		varchar(50)		NOT NULL
)