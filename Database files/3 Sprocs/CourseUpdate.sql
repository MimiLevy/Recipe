use RecipeDB
go

create or alter procedure dbo.CourseUpdate(
	@CourseId int output,
	@CourseName varchar(50),
	@Sequence int,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @CourseId = isnull(@CourseId,0)

	if @CourseId = 0
		begin
			insert Course(CourseName, Sequence)
			values (@CourseName, @Sequence)

			select @CourseId = scope_identity()
		end
	else 
		begin
			update Course
			set
			CourseName = @CourseName, 
			Sequence = @Sequence
			where CourseId = @CourseId
		end 

	return @return
end
go