CREATE PROCEDURE [dbo].[StockTake_Delete]
	@Id int
AS 
begin 
	delete 
	from dbo.[StockTake]
	where Id = @Id;
end
