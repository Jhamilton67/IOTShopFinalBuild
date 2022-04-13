CREATE PROCEDURE [dbo].[StockLevels_Delete]
	@Id int
AS
begin
	delete 
	from dbo.[StockLevels]
	where Id = @Id;
end