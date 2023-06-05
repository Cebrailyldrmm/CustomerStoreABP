using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.CustomerStore.Customers
{
    public class Customer_Address:AuditedAggregateRoot<Guid>
    {
        [Key]
        public  int Customer_Adress_Id { get; set; }

        public string Home_Adress { get; set; }

        public string Work_Address { get; set;}

        public string Family_Adress { get; set; }


    }
}
