use RecipeDB
go

create or alter procedure dbo.RecipeIngredientUpdate(
	@RecipeIngredientId int output,
	@RecipeId int,
	@IngredientId int,
	@MeasurementTypeId int,
	@Amount int,
	@Sequence int,
	@Message varchar(500) = ' ' output
)
as
begin
	declare @return int	

	select @RecipeIngredientId = isnull(@RecipeIngredientId, 0)

	if @RecipeIngredientId = 0
		begin
			insert RecipeIngredient(RecipeId, IngredientId, MeasurementTypeId, Amount, Sequence) 
			values (@RecipeId ,@IngredientId, @MeasurementTypeId, @Amount, @Sequence) 

			select @RecipeIngredientId = scope_identity()	
		end
	else
		begin
			update RecipeIngredient
			set
				RecipeId = @RecipeId, 
				IngredientId = @IngredientId, 
				MeasurementTypeId = @MeasurementTypeId, 
				Amount = @Amount, 
				"Sequence" = @Sequence
			where RecipeIngredientId = @RecipeIngredientId
		end

	return @return
end
go
