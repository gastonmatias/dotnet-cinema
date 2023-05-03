using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using back_end.Validaciones;

namespace back_end.entidades
{
    // clase qe representara tabla generos
    public class Genero: IValidatableObject
    {
        public int Id { get; set; }
        
        // [PrimeraLetraMayusculaAttribute]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public String Nombre { get; set; }

        [Range(18,120,ErrorMessage ="El campo {0} debe estar entre {1} y {2}")]
        public int Edad { get; set; }

        [CreditCard]
        public String TarjetaCredito { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!string.IsNullOrEmpty(Nombre))
            {
                var primeraLetra = Nombre[0].ToString();

                if (primeraLetra != primeraLetra.ToUpper())
                {
                    yield return new ValidationResult(
                        "La primera Letra debe ser mayúscula",
                        new string[]{nameof(Nombre)} // el error le corresponde al campo "Nombre"
                    );
                }
            }
        }
    }
}