use RecipeDB 
go

create or alter procedure dbo.CuisineTypeUpdate(
	@CuisineTypeId int output,
	@CuisineTypeDesc varchar(30),
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @CuisineTypeId = isnull(@CuisineTypeId,0)

	if @CuisineTypeId = 0
		begin
			insert CuisineType(CuisineTypeDesc)
			values (@CuisineTypeDesc)

			select @CuisineTypeId = scope_identity()
		end
	else 
		begin
			update CuisineType
			set
			CuisineTypeDesc = @CuisineTypeDesc
			where CuisineTypeId = @CuisineTypeId
		end 

	return @return
end
go