CREATE PROCEDURE [dbo].[Replen_Percentage]
	@Id int
AS 
begin 
	select Id, [Replen Count]
	from dbo.[Replen]
	where Id = @Id;
end