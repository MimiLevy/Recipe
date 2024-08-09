interface IRecipeIngredient {
    recipeIngredientId: number;
    recipeId: number;
    amount: number;
    ingredientId: number;
    measurementTypeId: number;
    ingredientName: string;
    measurementTypeDesc: string;
    sequence: number;
}

interface IRecipeStep {
    recipeStepId: number;
    recipeId: number;
    stepDesc: string;
    sequence: number;
}

export interface IRecipe {
    recipeIngredientList: IRecipeIngredient[];
    recipeStepList: IRecipeStep[];
    recipeId: number;
    staffId: number;
    cuisineTypeId: number;
    recipeName: string;
    user: string;
    calories: number;
    vegan: boolean;
    dateDrafted: string;
    datePublished: string;
    dateArchived: string | null;
    recipeStatus: string;
    recipePicture: string;
    numIngredients: number;
}

export interface ICuisineType {
    cuisineTypeId: number;
    cuisineTypeDesc: string;
}
