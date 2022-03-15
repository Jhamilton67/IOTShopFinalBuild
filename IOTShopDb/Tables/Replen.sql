CREATE TABLE [dbo].[Replen]
(
	[Id] INT NOT NULL  IDENTITY, 
    [StockID ] INT NOT NULL, 
    [Replen Count] INT NOT NULL,
    [StockType] NVARCHAR(50) NOT NULL, 
    [StockTypeSize] NVARCHAR(50) NOT NULL, 
    [StockTypeQuantityNeeded] INT NOT NULL, 
    CONSTRAINT [PK_Replen] PRIMARY KEY ([Id]), 
)
