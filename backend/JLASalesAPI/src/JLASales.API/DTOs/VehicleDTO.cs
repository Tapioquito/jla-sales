using System.ComponentModel.DataAnnotations;

namespace JLASales.API.DTOs
{
    public class VehicleDTO
    {

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres.", MinimumLength = 2)]
        public string ModelName { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(10, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres.", MinimumLength = 2)]
        public string MotorPower { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(11, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres.", MinimumLength = 11)]
        public string Document { get; set; }//Renavam

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string ReleaseYear { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres.", MinimumLength = 2)]
        public string Manufacturer { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(7, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres.", MinimumLength = 7)]
        public string LicensePlate { get; set; }//PLACA


        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public double Price { get; set; }

    }
}
