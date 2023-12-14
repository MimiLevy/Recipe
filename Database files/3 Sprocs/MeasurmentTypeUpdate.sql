use RecipeDB
go

create or alter procedure dbo.MeasurementTypeUpdate(
	@MeasurementTypeId int output,
	@MeasurementTypeDesc varchar(25),
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @MeasurementTypeId = isnull(@MeasurementTypeId,0)

	if @MeasurementTypeId = 0
		begin
			insert MeasurementType(MeasurementTypeDesc)
			values (@MeasurementTypeDesc)

			select @MeasurementTypeId = scope_identity()
		end
	else 
		begin
			update MeasurementType
			set
			MeasurementTypeDesc = @MeasurementTypeDesc
			where MeasurementTypeId = @MeasurementTypeId
		end 

	return @return
end
go