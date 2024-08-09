import { useState } from 'react'
import './assets/css/bootstrap.min.css'
import CuisineBar from './CuisineBar'
import MainScreen from './MainScreen'
import Navbar from './Navbar'
function App() {

  const [selectedCuisineTypeDesc, setSelectedCuisineTypeDesc] = useState("");
  function handleCuisineTypeSelected(cuisineTypeDesc: string) {
    setSelectedCuisineTypeDesc(cuisineTypeDesc);
  }

  return (
    <div className="container">
      <div className="row">
        <div className="col-12 px-0">
          <Navbar />
        </div>
        <div className="col-12 border px-0">
          <CuisineBar onCuisineTypeSelected={handleCuisineTypeSelected} />
        </div>
        <div className="col-12 px-0">
          <MainScreen cuisinetypedesc={selectedCuisineTypeDesc} />
        </div>
      </div>
    </div>
  )
}

export default App
