import { IRecipe } from "./DataInterfaces"

interface Props {
    recipe: IRecipe
}
export default function RecipeCard({ recipe }: Props) {
    return (
        <>
            <div className="card m-5">
                <img className="card-img-top image-fluid border" height={400} src={`/images/recipe-images/${recipe.recipePicture}`} alt="Card image cap" />
                <div className="card-body">
                    <h5 className="card-title"><b>{recipe.recipeName}</b></h5>
                    <hr />
                    <p className="card-text">
                        <ul>
                            <li>{recipe.calories} Calories</li>
                            <li>{recipe.recipeIngredientList.length} Ingredients</li>
                            <li>{recipe.recipeStepList.length} Steps</li>
                        </ul>
                    </p>
                    <a href="#" className="btn btn-primary">Go to Recipe</a>
                </div>
            </div>
        </>
    )
}