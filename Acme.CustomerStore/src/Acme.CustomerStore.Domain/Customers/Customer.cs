using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.CustomerStore.Customers
{
     public class Customer:AuditedAggregateRoot<Guid>
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Customer_Id { get; set; }
        
        [StringLength(50)]
        public string Name { get; set; }
        
        [StringLength(50)]
        public string Surname { get; set; }
        
        [StringLength(50)]
        public string Gender { get; set; }

        public int TC { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [ForeignKey("Customer_Adress")]
        public  int Customer_Adress_Id { get; set; }

        public Customer_Address Customer_Adress { get; set; }

        [ForeignKey("customer_contact")]
        public int Customer_Contact_Id { get; set; }

        public customer_contact customer_Contact { get; set; }

        [ForeignKey("Customer_Spending")]
        public int spending_Id { get; set; }

        public Customer_Spending Customer_Spending { get; set; }
    }
}
