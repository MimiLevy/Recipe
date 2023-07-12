create or alter procedure dbo.StaffGet
(
	@StaffId int = 0,
	@UserNAme varchar(30) = '',
	@All bit = 0
)
as 
begin
	
	select @UserNAme = nullif(@UserNAme, '')

	select s.StaffId, s.FirstName, s.LastName, s.UserName 
	from staff s
	where s.StaffId = @StaffId
	or s.UserName like '%' + @UserNAme + '%'
	or @All = 1
end
go

/*
exec StaffGet

declare @StaffId int 
select top 1 @StaffId = s.StaffId from Staff s
exec StaffGet @StaffId = @StaffId

exec StaffGet @UserName = ''
exec StaffGet @UserNAme = 'k'

exec StaffGet @All = 1
*/