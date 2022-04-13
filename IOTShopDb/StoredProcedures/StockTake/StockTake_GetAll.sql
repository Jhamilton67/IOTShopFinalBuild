CREATE PROCEDURE [dbo].[StockTake_GetAll]
AS 
begin 
	select Id, StockID, StockTakeCount,  StockType, StockTypeSize, StockTypePrice, StockTypeQuantity  
	from dbo.[StockTake];
end