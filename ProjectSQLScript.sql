CREATE DATABASE ElectronicSupermarket

GO
USE [ElectronicSupermarket]
GO

CREATE TABLE [dbo].[WAREHOUSE](
			[PRODUCT_ID] [varchar] PRIMARY KEY,
			[INSTOCK_QUANTITY] [int] NOT NULL
)

CREATE TABLE [dbo].[SUPPLIER](
			[SUPPLIER_ID] [varchar] PRIMARY KEY,
			[SUPPLIER_NAME] [nvarchar] (255) UNIQUE,
			[CONTACT_NAME] [nvarchar] (255),
			[SUPPLIER_PHONE] [int],
			[SUPPLIER_EMAIL] [varchar] (255),
			[SUPPLIER_ADDRESS] [nvarchar] (255)
)

CREATE TABLE [dbo].[CATEGORY](
			[CATEGORY_ID] [int] PRIMARY KEY,
			[CATEGORY_NAME] [nvarchar] (255) NOT NULL
)

CREATE TABLE [dbo].[PRODUCT](
			[PRODUCT_ID] [varchar] (255) PRIMARY KEY ,
			[PRODUCT_NAME] [nvarchar] (255) NOT NULL UNIQUE,
			[CATEGORY_ID] [int] ,
			[PRODUCT_IMAGE] [varbinary] (MAX),
			[PRODUCT_PRICE] [float],
			[SUPPLIER_ID] [int],
			[PRODUCT_DESC] [nvarchar] (255),
			FOREIGN KEY (PRODUCT_ID) REFERENCES WAREHOUSE(PRODUCT_ID),
			FOREIGN KEY (CATEGORY_ID) REFERENCES CATEGORY(CATEGORY_ID)
)

UPDATE PRODUCT
SET PRODUCT_IMAGE =
      (SELECT * FROM OPENROWSET(BULK N'D:\Works\C#\Project\LTUDC5_PhatLongCuongThinh\laptopimg1.jpg', SINGLE_BLOB) AS P_IMAGE)
WHERE PRODUCT_ID = 'lptp001';

UPDATE PRODUCT
SET PRODUCT_IMAGE =
      (SELECT * FROM OPENROWSET(BULK N'D:\Works\C#\Project\LTUDC5_PhatLongCuongThinh\laptopimg2.jpg', SINGLE_BLOB) AS P_IMAGE)
WHERE PRODUCT_ID = 'lptp002';

CREATE TABLE [dbo].[STATISTIC](
			[STATISTIC_ID] [nvarchar] PRIMARY KEY,
			[STATISTIC_EMLOYEE] [nvarchar] (255) UNIQUE,
			[STATISTIC_BILL] [nvarchar] (255),
			[STATISTIC_PRICE] [int],
			[USER_ID] [nvarchar]
)

CREATE TABLE [dbo].[USER] (
			[USER_KEY] [varchar] (255) PRIMARY KEY,
			[USER_NAME] [nvarchar] (255) NOT NULL UNIQUE,
			[USER_SELFPHONE] [int],
			[USER_GMAIL] [nvarchar] (255),
			/*Employee Type doi Long add Table roi update sau*/
)
CREATE TABLE [dbo].[BILL](
			[BILL_ID] [nvarchar] PRIMARY KEY,
			[USER_KEY] [nvarchar],
			[USER_NAME] [nvarchar],
			[PRODUCT_ID] [nvarchar],
			/*EMPLOYEE_ID chờ cập nhật*/
			[BILL_DATE] [date],
			[BILL_METHOD] [nvarchar] (255),
			[BILL_PAY] [nvarchar] (255)			
)