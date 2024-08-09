import { useEffect, useState } from "react"
import { ICuisineType } from "./DataInterfaces"
import CuisineButton from "./CuisineButton"
import { fetchCuisineTypes } from "./DataUtil"

interface Props {
    onCuisineTypeSelected: (cuisineTypeDesc: string) => void
}

export default function CuisineBar({ onCuisineTypeSelected }: Props) {
    const [cuisineTypeList, setCuisineTypeList] = useState<ICuisineType[]>([])
    const [selectedCuisineTypeDesc, setSelectedCuisineTypeDesc] = useState("");

    useEffect(() => {
        const fetchData = async () => {
            const data = await fetchCuisineTypes();
            setCuisineTypeList(data);
            if (data.length) {
                handleSelectedCuisineType(data[0].cuisineTypeDesc)
            }
        }
        fetchData();
    },
        []);

    function handleSelectedCuisineType(cuisineTypeDesc: string) {
        setSelectedCuisineTypeDesc(cuisineTypeDesc);
        onCuisineTypeSelected(cuisineTypeDesc);
    }

    return (
        <>
            <div className="container flex bg-primary bg-opacity-75">
                <div className="row justify-content-center">
                    {cuisineTypeList.map(c => <div key={c.cuisineTypeId} className="col-lg-2 col-md-4 col-sm-6 "><CuisineButton cuisineType={c} isSelected={c.cuisineTypeDesc == selectedCuisineTypeDesc} onSelected={handleSelectedCuisineType} /></div>)}
                </div>
            </div>
        </>
    )
}