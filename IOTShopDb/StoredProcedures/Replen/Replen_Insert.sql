CREATE PROCEDURE [dbo].[Replen_Insert]
	@StockID int,
    @Replen_Count int,
    @stockType Nvarchar(50),
    @stockTypeSize Nvarchar(50),
    @stockTypeQuantityNeeded int
AS
begin 
     insert into dbo.[Replen] ([StockID ], [Replen Count], StockType, StockTypeSize, StockTypeQuantityNeeded)
     values (@StockID, @Replen_Count, @stockType, @stockTypeSize, @stockTypeQuantityNeeded)
end