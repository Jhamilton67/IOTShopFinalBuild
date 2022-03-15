CREATE TABLE [dbo].[Overview]
(
	[Id] INT NOT NULL IDENTITY , 
    [Hourly] DATETIME NOT NULL, 
    [Day ] DATE NOT NULL, 
    [StockTake Count] INT NOT NULL,
    [StockID] INT NOT NULL, 
    [Replen Count] INT NOT NULL, 
    [Stock Levels] INT NOT NULL, 
    [FootFall Count] INT NOT NULL, 
    CONSTRAINT [PK_Overview] PRIMARY KEY ([Id])
)
