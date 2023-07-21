using AutoMapper;
using JLASales.API.Configurations;
using JLASales.API.DTOs;
using JLASales.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JLASales.API.Controllers
{
    [Route("api/vendedores")]
    public class VendorController : MainController
    {

        private readonly IVendorRepository _vendorRepository;
        private readonly IMapper _mapper;
        public VendorController(IVendorRepository vendorRepository,
                               IMapper mapper)
        {
            _vendorRepository = vendorRepository;
            _mapper = mapper;
        }
        public async Task<ActionResult<IEnumerable<VendorDTO>>> getAllVendors()
        {
            var vendor = _mapper.Map<IEnumerable<VendorDTO>>(await _vendorRepository.GetAll());

            return Ok(vendor);
        }
    }
}