CREATE PROCEDURE [dbo].[StockLevels_GetAll]
	AS 
begin 
	select Id, [StockLevels], StockID, StockLevels, StockImage, Quantity 
	from dbo.[StockLevels];
end
