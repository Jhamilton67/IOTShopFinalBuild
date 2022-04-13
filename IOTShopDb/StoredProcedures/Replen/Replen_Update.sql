CREATE PROCEDURE [dbo].[Replen_Update]
	@ID int,
    @StockID int,
    @Replen_Count int,
    @StockType Nvarchar(50),
    @StockTypeSize Nvarchar(50),
    @StockTypeQunatityNeeded int
AS
begin 
    update dbo.[Replen] set 
    [StockID ] = @StockID,
    [Replen Count] = @Replen_Count,
    StockType = @StockType,
    StockTypeSize = @StockTypeSize,
    StockTypeQuantityNeeded = @StockTypeQunatityNeeded
    where Id = @ID
end
