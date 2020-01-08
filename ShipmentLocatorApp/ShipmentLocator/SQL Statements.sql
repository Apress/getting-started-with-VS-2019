/* CREATE TABLE STATEMENT */
CREATE TABLE [dbo].[menu] (
    [itemName] VARCHAR (50)   NOT NULL,
    [category] VARCHAR (50)   NOT NULL,
    [price]    DECIMAL (5, 2) NULL,
    CONSTRAINT [PK_menu] PRIMARY KEY CLUSTERED ([itemName] ASC)
);

/* MODIFIED CREATE TABLE STATEMENT */
CREATE TABLE [dbo].[menu] (
    [itemName] VARCHAR (50)   NOT NULL,
    [category] VARCHAR (50)   NOT NULL,
    [price]    DECIMAL (5, 2) NULL,	
    [priceCategory]    VARCHAR (5) NULL,
    CONSTRAINT [PK_menu] PRIMARY KEY CLUSTERED ([itemName] ASC)
);

/* SELECT TABLE STATEMENT */
SELECT 
	itemName
	, category
	, price
	, priceCategory 
FROM menu

/* INSERT ITEM INTO TABLE */
INSERT INTO [dbo].[menu]
	([itemName],[category],[price],[priceCategory])
VALUES
	('bread','breads',2.50,'baker')

/* UPDATE TABLE STATEMENT */
UPDATE menu
SET priceCategory = 'DELI'
WHERE category IN ('meats', 'salads', 'soups')








