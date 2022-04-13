CREATE PROCEDURE [dbo].[StockTake_Insert]
	@StockID int,
	@StockTakeCount int,
	@StockType nvarchar(50),
	@StockTypeSize nvarchar(50),
	@StockTypePrice Money,
	@StockTypeQuantity int 

AS 
begin 
	insert into dbo.[StockTake] (StockID, StockTakeCount, StockType, StockTypeSize,
	StockTypePrice, StockTypeQuantity) 
	values (@StockID, @StockTakeCount, @StockType, @StockTypeSize, @StockTypePrice, @StockTypeQuantity); 
end