use RecipeDB
go

create or alter procedure dbo.CourseGet(
	@CourseId int = 0,
	@All bit = 0,
	@Message varchar(500) = '' output
)
as
begin 
	declare @return int = 0

	select @CourseId = isnull(@CourseId,0), @All = isnull(@All,0)

	select c.CourseId, c.CourseName, c.Sequence
	from Course c
	where c.CourseId = @CourseId
	or @All = 1
	order by c.Sequence

	return @return
end
go