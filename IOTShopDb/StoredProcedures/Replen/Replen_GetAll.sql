CREATE PROCEDURE [dbo].[Replen_GetAll]
AS 
begin 
	select Id, [Replen Count], [StockID ]   StockType, StockTypeSize, StockTypeQuantityNeeded
	from dbo.[Replen];
end