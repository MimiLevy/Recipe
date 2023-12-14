use RecipeDB
go

create or alter procedure dbo.CuisineTypeGet(
	@CuisineTypeId int = 0,
	@CuisineTypeDesc varchar(30) = '',
	@All bit = 0
)
as
begin
	declare @return int = 0

	select @CuisineTypeId = isnull(@CuisineTypeId,0), @All = isnull(@All,0)

	select c.CuisineTypeId, c.CuisineTypeDesc
	from CuisineType c
	where c.CuisineTypeId = @CuisineTypeId
	or (@CuisineTypeDesc <> '' and c.CuisineTypeDesc like '%' + @CuisineTypeDesc + '%')
	or @All = 1

	return @return
end 
go

/*
exec CuisineTypeGet

declare @CuisineTypeid int
select top 1 @CuisineTypeid = c.CuisineTypeId from CuisineType c
exec CuisineTypeGet @CuisineTypeId = @CuisineTypeId

exec CuisineTypeGet @CuisinetypeDesc = ''
exec CuisineTypeGet @CuisinetypeDesc = 'j'

exec CuisineTypeGet @All = 1
*/



