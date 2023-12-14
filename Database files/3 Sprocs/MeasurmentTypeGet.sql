use RecipeDB
go

create or alter procedure dbo.MeasurementTypeGet(
	@MeasurementTypeId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(1000) = '' output
)
as
begin 
	declare @return int = 0

	select @MeasurementTypeId = isnull(@MeasurementTypeId,0), @All = isnull(@All,0)

	select m.MeasurementTypeId, m.MeasurementTypeDesc
	from MeasurementType m
	where m.MeasurementTypeId = @MeasurementTypeId
	or @All = 1
	union select 0, ' '
	where @IncludeBlank = 1

	return @return
end
go

--exec MeasurementTypeGet @All = 1