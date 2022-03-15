CREATE TABLE [dbo].[StockTake]
(
	[Id] INT NOT NULL  IDENTITY,
    [StockTakeCount] INT NOT NULL,
	[StockID] INT NOT NULL, 
    [StockType] NVARCHAR(50) NOT NULL, 
    [StockTypeSize] NVARCHAR(50) NOT NULL, 
    [StockTypePrice] MONEY NOT NULL, 
    [StockTypeQuantity] INT NOT NULL, 
    CONSTRAINT [PK_StockTake] PRIMARY KEY ([Id]), 
)
