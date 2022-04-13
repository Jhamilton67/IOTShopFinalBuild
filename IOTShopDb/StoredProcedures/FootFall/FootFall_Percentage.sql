CREATE PROCEDURE [dbo].[FootFall_Percentage]
	@Id int
AS 
begin 
	select Id, [FootFallCounter]
	from dbo.[FootFall]
	where Id = @Id;
end 