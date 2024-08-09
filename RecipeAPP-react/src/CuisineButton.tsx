import { ICuisineType } from "./DataInterfaces"

interface Props {
    cuisineType: ICuisineType,
    isSelected: boolean,
    onSelected: (CuisineTypeDesc: string) => void
}

export default function CuisineButton({ cuisineType, isSelected, onSelected }: Props) {
    return (
        <>
            <div onClick={() => onSelected(cuisineType.cuisineTypeDesc)} className={`btn m-3 ${isSelected ? "bg-primary-subtle" : ""}`}>
                <figure className="figure">
                    <h5><figcaption className="figure-caption text-center">{cuisineType.cuisineTypeDesc}</figcaption></h5>
                    <img src={`/images/cuisine-images/${cuisineType.cuisineTypeDesc}.jpg`} width={200} height={200} className="figure-img  rounded" alt="A generic square placeholder image with rounded corners in a figure." />
                </figure>
            </div>
        </>
    )
}