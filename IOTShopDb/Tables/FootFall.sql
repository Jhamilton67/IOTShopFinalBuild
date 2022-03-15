CREATE TABLE [dbo].[FootFall]
(
	[Id] INT NOT NULL, 
    [FootFallCounter] INT NOT NULL,
    [Hourly] DATETIME NOT NULL, 
    [DayofWeek] DATE NOT NULL, 
    CONSTRAINT [PK_FootFall] PRIMARY KEY ([Id])
)
