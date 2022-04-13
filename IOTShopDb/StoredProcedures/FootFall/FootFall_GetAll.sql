CREATE PROCEDURE [dbo].[FootFall_GetAll]
	AS 
begin 
	select Id, [FootFallCounter], DayofWeek, Hourly 
	from dbo.[FootFall];
end