CREATE PROCEDURE [dbo].[FootFall_Update]
	@ID int,
	@FootFallCounter int,
    @Hourly DATETIME, 
    @DayofWeek Date 
AS
begin 
    update dbo.[FootFall] set 
    FootFallCounter = @FootFallCounter,
    Hourly = @Hourly,
    DayofWeek = @DayofWeek
    where Id = @ID
end
