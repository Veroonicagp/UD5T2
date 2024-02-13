using PropertyChanged;

namespace UD5T2.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class BMI
    {
        string resultadoBMI;

        /// <summary>
        /// Declaramos la altura
        /// </summary>
        public float Altura { get; set; }

        /// <summary>
        /// Declaramos el peso
        /// </summary>
        public float Peso { get; set; }

        /// <summary>
        /// calculo de el resultado par la aguja
        /// </summary>
        public float Resultado
        {
            get { return (float)(Peso / Math.Pow(Altura, 2) * 10000); }
        }

        /// <summary>
        /// Mensajes de referencia
        /// </summary>
        public string ResultadoBMI
        {
            get
            {
                if (Resultado > 0 && Resultado <= 16)
                {
                    resultadoBMI = "BMI: Delgado Severo";
                }
                else if (Resultado > 16 && Resultado <= 17)
                {
                    resultadoBMI = "BMI: Delgado Moderado";
                }
                else if (Resultado > 17 && Resultado <= 18.5)
                {
                    resultadoBMI = "BMI: Delgado Medio";
                }
                else if (Resultado > 18.5 && Resultado <= 25)
                {
                    resultadoBMI = "BMI: Normal";
                }
                else if (Resultado > 25 && Resultado <= 30)
                {
                    resultadoBMI = "BMI: Sobrepeso";
                }
                else if (Resultado > 30 && Resultado <= 35)
                {
                    resultadoBMI = "BMI Obesidad Clase I";
                }
                else if (Resultado > 35 && Resultado <= 40)
                {
                    resultadoBMI = "BMI: Obesidad Clases II";
                }
                else
                {
                    resultadoBMI = "BMI: Obesidad Clase III";
                }


                return resultadoBMI;
            }


        }
    }
}

