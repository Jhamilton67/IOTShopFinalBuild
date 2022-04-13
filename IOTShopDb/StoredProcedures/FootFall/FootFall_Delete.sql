CREATE PROCEDURE [dbo].[FootFall_Delete]
	@Id int
AS
begin
	delete 
	from dbo.[FootFall]
	where Id = @Id;
end