using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace CustomerStore.Customers
{
    public interface ICustomerAppService: ICrudAppService<CustomerDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateCustomerDto> // crud işlemler
    {

    }
}
