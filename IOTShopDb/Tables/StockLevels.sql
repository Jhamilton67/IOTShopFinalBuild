CREATE TABLE [dbo].[StockLevels]
(
	[Id] INT NOT NULL IDENTITY , 
    [StockID] INT NOT NULL, 
    [StockLevels] INT NOT NULL,
    [StockType] NVARCHAR(50) NOT NULL, 
    [Quantity] INT NOT NULL, 
    [StockImage] NVARCHAR(500) NOT NULL, 
    CONSTRAINT [PK_StockLevels] PRIMARY KEY ([Id])
)
