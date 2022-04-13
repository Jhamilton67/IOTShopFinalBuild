CREATE PROCEDURE [dbo].[StockTake_CountPercent]
	@Id int
AS 
begin 
	select Id, StockID, [StockTakeCount]  
	from dbo.[StockTake]
	where Id = @Id;
end