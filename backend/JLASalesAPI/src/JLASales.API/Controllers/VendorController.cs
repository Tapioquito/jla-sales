using AutoMapper;
using JLASales.API.Configurations;
using JLASales.API.DTOs;
using JLASales.Business.Interfaces;
using JLASales.Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace JLASales.API.Controllers
{
    [Route("api/vendedores")]
    public class VendorController : MainController
    {

        private readonly IVendorRepository _vendorRepository;
        private readonly IVendorService _vendorService;
        private readonly IMapper _mapper;


        public VendorController(IVendorRepository vendorRepository,
                                IVendorService vendorService,
                               IMapper mapper)
        {
            _vendorRepository = vendorRepository;
            _vendorService = vendorService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<VendorDTO>>> GetAllVendors()
        {
            var vendor = _mapper.Map<IEnumerable<VendorDTO>>(await _vendorRepository.GetAll());

            return Ok(vendor);
        }


        [HttpGet("{id:guid}")]
        public async Task<ActionResult<VendorDTO>> GetById(Guid id)
        {
            var vendor = await GetVendorSalesAddress(id);


            if (vendor == null) return NotFound();

            return vendor;
        }
        [HttpGet("{id:guid}")]
        public async Task<VendorDTO> GetVendorSalesAddress(Guid id)
        {
            return _mapper.Map<VendorDTO>(await _vendorRepository.GetVendorSalesAndress(id));
        }

        [HttpGet("{id:guid}")]
        public async Task<VendorDTO> GetVendorAddress(Guid id)
        {
            return _mapper.Map<VendorDTO>(await _vendorRepository.GetVendorsAdress(id));
        }

        [HttpPost]
        public async Task<ActionResult<VendorDTO>> Add(VendorDTO vendorDTO)
        {
            if (!ModelState.IsValid) return BadRequest();

            var vendor = _mapper.Map<Vendor>(vendorDTO);

            var result = await _vendorService.Add(vendor);

            if (!result) return BadRequest();

            return Ok(vendor);

        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<VendorDTO>> Update(Guid id, VendorDTO vendorDTO)
        {

            if (id != vendorDTO.Id) return BadRequest();

            if (!ModelState.IsValid) return BadRequest();

            var vendor = _mapper.Map<Vendor>(vendorDTO);

            var result = await _vendorService.Update(vendor);

            if (!result) return BadRequest();

            return Ok(vendor);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<VendorDTO>> Delete(Guid id)
        {
            var vendor = await GetVendorAddress(id);


            if (vendor == null) return NotFound();

            var result = await _vendorService.Delete(id);

            if (!result) return BadRequest();

            return Ok(vendor);
        }

    }
}