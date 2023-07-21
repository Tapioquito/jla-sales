using System.ComponentModel.DataAnnotations;

namespace JLASales.API.DTOs
{
    public class SaleDTO
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Guid VendorId { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório")]

        public Guid VehicleId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]

        public Guid SaleValue { get; set; }


        public string VendorName { get; set; }

    }
}
