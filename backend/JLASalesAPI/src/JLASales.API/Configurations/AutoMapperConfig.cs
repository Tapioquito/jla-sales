using AutoMapper;
using JLASales.API.DTOs;
using JLASales.Business.Models;

namespace JLASales.API.Configurations
{
    public class AutoMapperConfig : Profile
    {

        public AutoMapperConfig()
        {
            CreateMap<Vendor, VendorDTO>().ReverseMap();

            CreateMap<Address, AddressDTO>().ReverseMap();

            CreateMap<Vehicle, VehicleDTO>().ReverseMap();

        }
    }
}
