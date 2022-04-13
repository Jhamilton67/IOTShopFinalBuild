CREATE PROCEDURE [dbo].[Replen_Delete]
	@Id int
AS
begin
	delete 
	from dbo.[Replen]
	where Id = @Id;
end