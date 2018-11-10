CREATE DATABASE ElectronicSupermarket

USE [ElectronicSupermarket]
GO

CREATE TABLE [dbo].[WAREHOUSE](
			[PRODUCT_ID] [varchar] (255) PRIMARY KEY,
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
			[USER_ID] [varchar] (255) PRIMARY KEY,
			[USER_PASS] [varchar] (255) NOT NULL,
			[USER_STATUS] [nvarchar] (255) NOT NULL UNIQUE,
			[USER_NAME] [nvarchar] (255) NOT NULL UNIQUE,
			[USER_PHONE] [int],
			[USER_EMAIL] [nvarchar] (255),
			[USER_TYPE] [varchar] (255),
)

/*Emloyee*/
CREATE TABLE [dbo].[EMLOYEE_TYPE](
			[TYPE_ID] [int] PRIMARY KEY,
			[TYPE_NAME] [nvarchar] (255) NOT NULL
)
CREATE TABLE [dbo].[EMLOYEE_ROOM](
			[ROOM_ID] [int] PRIMARY KEY,
			[ROOM_NAME] [nvarchar] (255) NOT NULL
)

CREATE TABLE [dbo].[EMLOYEE](
			[EMLOYEE_ID] [varchar] (255) PRIMARY KEY ,
			[EMLOYEE_NAME] [nvarchar] (255) NOT NULL UNIQUE,
			[EMLOYEE_TYPE_ID] [int],
			[EMLOYEE_IMAGE] [varbinary] (MAX),
			[EMLOYEE_GMAIL] [nvarchar] (255),
			[EMLOYEE_PHONE] [nvarchar] (255),
			[EMLOYEE_DATE] [datetime],
			[EMLOYEE_ADDRESS] [nvarchar] (255),
			[EMLOYEE_ROOM_ID] [int],	
			[EMLOYEE_STATISTIC] [nvarchar] (255),
			[USER_ID] [varchar] (255),
			FOREIGN KEY (EMLOYEE_TYPE_ID) REFERENCES EMLOYEE_TYPE(TYPE_ID),
			FOREIGN KEY (EMLOYEE_ROOM_ID) REFERENCES EMLOYEE_ROOM(ROOM_ID),
			FOREIGN KEY (USER_ID) REFERENCES USER(USER_ID)
>>>>>>> 4e16e29fad388c8274d2481d26eab1b945ed4b16
)

CREATE TABLE [dbo].[BILL](
			[BILL_ID] [nvarchar] PRIMARY KEY,
			[USER_KEY] [nvarchar],
			[USER_NAME] [nvarchar],
			[PRODUCT_ID] [nvarchar],
			[EMPLOYEE_ID] [nvarchar],
			[BILL_DATE] [date],
			[BILL_METHOD] [nvarchar] (255),
			[BILL_PAY] [nvarchar] (255)	
)