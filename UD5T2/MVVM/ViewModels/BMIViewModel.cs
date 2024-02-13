using UD5T2.MVVM.Models;

namespace UD5T2.MVVM.ViewModels
{
    public class BMIViewModel
    {   

        /// <summary>
        /// propiedad de BMI
        /// </summary>
        public BMI BMI{ get; set; }
        
        /// <summary>
        /// propiedades predeminadas de un objeto
        /// </summary>
        public BMIViewModel()
        {
            BMI = new BMI();
            BMI.Altura = 25;
            BMI.Peso = 50;
        }

    }
}
