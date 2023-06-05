using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.CustomerStore.Customers
{
    public class customer_contact:AuditedAggregateRoot<Guid>
    {
        [Key]
        public int Customer_Contact_Id { get; set; }
    
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string WorkPhoneNumber { get; set; }

        public string HomePhoneNumber { get; set;}
    }
}
