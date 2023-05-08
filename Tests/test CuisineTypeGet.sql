exec CuisineTypeGet

declare @CuisineTypeid int
select top 1 @CuisineTypeid = c.CuisineTypeId from CuisineType c
exec CuisineTypeGet @CuisineTypeId = @CuisineTypeId

exec CuisineTypeGet @CuisinetypeDesc = ''
exec CuisineTypeGet @CuisinetypeDesc = 'j'

exec CuisineTypeGet @All = 1