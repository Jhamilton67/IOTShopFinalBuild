CREATE PROCEDURE [dbo].[StockLevels_Insert]
	@StockID int, 
    @StockLevels int,
    @StockType Nvarchar(50),
    @Quantity int,
    @StockImage Nvarchar(500)
AS
begin 
     insert into dbo.[StockLevels] (StockID, StockLevels, StockType, Quantity, StockImage)
     values (@StockID, @StockLevels, @StockType, @Quantity, @StockImage)
end