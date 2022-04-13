CREATE PROCEDURE [dbo].[StockLevels_Percentage]
	@Id int
AS 
begin 
	select Id, [StockLevels]
	from dbo.[StockLevels]
	where Id = @Id;
end
