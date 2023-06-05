using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CustomerStore.Customers
{
    public class CustomerAppService : ICrudAppService<CustomerDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateCustomerDto>,ICustomerAppService // crud işlemler

    {
        

        public Task<CustomerDto> CreateAsync(CreateUpdateCustomerDto input)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerDto> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultDto<CustomerDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerDto> UpdateAsync(Guid id, CreateUpdateCustomerDto input)
        {
            throw new NotImplementedException();
        }
    }
}
