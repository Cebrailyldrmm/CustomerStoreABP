using AutoMapper;
using CustomerStore.Customers;

namespace CustomerStore;

public class CustomerStoreApplicationAutoMapperProfile : Profile
{
    public CustomerStoreApplicationAutoMapperProfile()
    {
        CreateMap<Customer, CustomerDto>();
        CreateMap<CreateUpdateCustomerDto, Customer>();
    }
}
