create or alter procedure dbo.StaffGet(
	@StaffId int = 0,
	@UserNAme varchar(30) = '',
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0

	select @StaffId = isnull(@StaffId,0), @UserNAme = nullif(@UserNAme, '')

	select s.StaffId, s.FirstName, s.LastName, s.UserName 
	from staff s
	where s.StaffId = @StaffId
	or s.UserName like '%' + @UserNAme + '%'
	or @All = 1
	union select 0, '', '', ''
	where @IncludeBlank = 1
	order by s.FirstName

	return @return
end
go

--exec StaffGet @All = 1, @IncludeBlank = 1
/*
exec StaffGet

declare @StaffId int 
select top 1 @StaffId = s.StaffId from Staff s
exec StaffGet @StaffId = @StaffId

exec StaffGet @UserName = ''
exec StaffGet @UserNAme = 'k'

exec StaffGet @All = 1
*/