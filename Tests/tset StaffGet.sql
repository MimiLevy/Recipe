exec StaffGet

declare @StaffId int 
select top 1 @StaffId = s.StaffId from Staff s
exec StaffGet @StaffId = @StaffId

exec StaffGet @UserName = ''
exec StaffGet @UserNAme = 'k'

exec StaffGet @All = 1