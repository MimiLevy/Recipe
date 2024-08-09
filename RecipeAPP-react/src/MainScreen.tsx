import { useEffect, useState } from "react"
import { IRecipe } from "./DataInterfaces"
import { fetchRecipesByCusineTypeDesc } from "./DataUtil";
import RecipeCard from "./RecipeCard";

interface Props {
    cuisinetypedesc: string
}

export default function MainScreen({ cuisinetypedesc }: Props) {
    const [recipeList, setRecipeList] = useState<IRecipe[]>([]);
    const [isLoading, setIsLoading] = useState(false);
    useEffect(() => {
        if (cuisinetypedesc != '') {
            setIsLoading(true);
            const fetchData = async () => {
                const data = await fetchRecipesByCusineTypeDesc(cuisinetypedesc);
                setRecipeList(data);
                setIsLoading(false);
            };
            fetchData()
        }
    }
        , [cuisinetypedesc])
    return (
        <>
            <div className="container bg-primary-subtle">
                <div className="row m-3">
                    <div className={isLoading ? "placeholder-glow" : ""}>
                        <h2 className="text-center mt-3">
                            <span className={isLoading ? "placeholder" : ""}>{recipeList.length} Recipes</span>
                        </h2>
                    </div>
                </div>
                <hr />
                <div className="row">
                    {recipeList.map(r =>
                        <div key={r.recipeId} className="col-md-12 col-lg-6 mb-2">
                            <RecipeCard recipe={r} />
                        </div>
                    )}
                </div>
            </div>
        </>
    )
}