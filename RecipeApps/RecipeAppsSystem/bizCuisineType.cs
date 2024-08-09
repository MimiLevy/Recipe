using CPUFramework;
using System.ComponentModel;

namespace RecipeAppsSystem
{
    public class bizCuisineType : bizObject<bizCuisineType>
    {
        public bizCuisineType()
        {

        }

        private int _cuisinetypeid;
        private string _cuisinetypedesc = "";

        public int CuisineTypeId
        {
            get { return _cuisinetypeid; }
            set
            {
                if (_cuisinetypeid != value)
                {
                    _cuisinetypeid = value;
                    InvokePropertyChanged();
                }
            }

        }

        public string CuisineTypeDesc
        {
            get { return _cuisinetypedesc; }
            set
            {
                if (_cuisinetypedesc != value)
                {
                    _cuisinetypedesc = value;
                    InvokePropertyChanged();
                }
            }

        }
    }
}
