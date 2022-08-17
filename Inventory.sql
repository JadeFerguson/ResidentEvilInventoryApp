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
		, Ammo			varchar(50)		NULL
		, FirstAid		varchar(50)		NULL
		, Fuel			varchar(50)		NULL
		, Herbs			varchar(50)		NULL
		, Misc			varchar(50)		NULL
		, Supplements	varchar(50)		NULL
		, Weapons		varchar(50)		NULL
)