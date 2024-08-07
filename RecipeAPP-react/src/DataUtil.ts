import { ICuisineType, IRecipe } from "./DataInterfaces";

const baseurl = "https://mlrecipeapi.azurewebsites.net/api/"

async function fetchData<T>(url: string): Promise<T> {
    url = baseurl + url;
    const r = await fetch(url);
    const data = await r.json();
    return data;
}

export async function fetchCuisineTypes() {
    return fetchData<ICuisineType[]>("cuisinetype");
}

export async function fetchRecipesByCusineTypeDesc(cuisineTypeDesc: string) {
    return fetchData<IRecipe[]>("recipe/getbycuisinetype/" + cuisineTypeDesc)
}
