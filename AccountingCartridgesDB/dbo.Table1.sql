CREATE TABLE [dbo].[Table1]
(
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	RequestId INT,
	Department nvarchar(50),
	Cartridge nvarchar(20),
	Quantity int,
	DeliveryDate Date,
)
