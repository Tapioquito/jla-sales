﻿using System.ComponentModel.DataAnnotations;

namespace JLASales.API.DTOs
{
    public class VendorDTO
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres.", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(11, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres.", MinimumLength = 11)]
        public string Document { get; set; }
        public AddressDTO Address { get; set; }
        public bool ActiveFlag { get; set; }

        public IEnumerable<SaleDTO> Sales { get; set; }
    }
}
