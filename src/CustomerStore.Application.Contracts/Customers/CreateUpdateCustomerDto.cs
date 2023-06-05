using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Net;
using System.Text;

namespace CustomerStore.Customers
{
    public class CreateUpdateCustomerDto
    {
        [Required]
        [StringLength(128)]
        public string Firstname { get; set; }

        [Required]
        [StringLength(128)]
        public string Lastname { get; set; }
        
        [Required]
        public string TcKimlik { get; set; }

        [Required]
        public bool IsUnusualName { get; set; } // Sıradışı isim işareti

        public ICollection<Contact> Contacts { get; set; }
        public ICollection<Address> Addresses { get; set; }


    }
    public class Contact 
    {
        [Required]
        public ContactType Type2 { get; set; }

        public string Value { get; set; }
        // Diğer özellikler

        public Guid CustomerId { get; set; }
        public CreateUpdateCustomerDto Customer { get; set; }
    }
    public class Address 
    {
        [Required]
        public AddressType Type { get; set; }
        [Required]
        public string Value { get; set; }
        // Diğer özellikler
        [Required]
        public Guid CustomerId { get; set; }
        [Required]
        public CreateUpdateCustomerDto Customer { get; set; }
    }
    public class ExpensePurposee 
    {
        [Required]
        public ExpensePurposeTybe Tybe { get; set; }
        [Required]
        public string value { get; set; }
        // Diğer özellikler
        [Required]
        public ICollection<CustomerExpensePurposee> CustomerExpensePurposes { get; set; }
    }
    public class CustomerExpensePurposee
    {
        [Required]     
        public Guid CustomerId { get; set; }
        [Required]
        public CustomerDto Customer { get; set; }
        [Required]
        public Guid ExpensePurposeId { get; set; }
        [Required]
        public ExpensePurpose ExpensePurpose { get; set; }
    }

}


