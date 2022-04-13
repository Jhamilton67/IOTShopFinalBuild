CREATE PROCEDURE [dbo].[StockTake_Update]
	@Id int,
	@StockID int,
	@StockTakeCount int,
	@StockType nvarchar(50),
	@StockTypeSize nvarchar(50),
	@StockTypePrice Money,
	@StockTypeQuantity int 
AS
begin 
	update dbo.[StockTake] set 
	StockID = @StockID,
	StockTakeCount = StockTakeCount,
	StockType = StockType,
	StockTypeSize = @StockTypeSize,
	StockTypePrice = @StockTypePrice,
	StockTypeQuantity = @StockTypeQuantity
	where Id = @Id;
end

