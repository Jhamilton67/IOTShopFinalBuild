CREATE PROCEDURE [dbo].[FootFall_Insert]
	@FootFallCounter int,
    @Hourly DATETIME, 
    @DayofWeek Date 
AS
begin 
     insert into dbo.[FootFall] (FootFallCounter, Hourly, DayofWeek)
     values (@FootFallCounter, @Hourly, @DayofWeek)
end