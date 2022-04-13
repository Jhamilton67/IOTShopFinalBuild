CREATE PROCEDURE [dbo].[StockLevels_Update]
	 @ID int, 
	@StockID int,
    @StockLevels int,
    @StockType Nvarchar(50),
    @Quantity int,
    @StockImage Nvarchar(500)
AS
begin 
    update dbo.[StockLevels] set 
    StockID = @StockID,
    StockLevels = @StockLevels, 
    StockType = @StockType,
    Quantity = @Quantity,
    StockImage = @StockImage
    where Id = @ID
end