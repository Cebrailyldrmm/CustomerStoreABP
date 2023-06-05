using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace CustomerStore.Customers
{
    // Customer tablosu
    public class Customer:AuditedAggregateRoot<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcKimlikNo { get; set; }
        public bool IsUnusualName { get; set; } // Sıradışı isim işareti
        public ICollection<Contact> Contacts { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<CustomerExpensePurpose> CustomerExpensePurposes { get; set; }
    }
    // Contact tablosu
    public class Contact : AuditedAggregateRoot<Guid>
    {
        public ContactType Type2 { get; set; }
        public string Value { get; set; }
        // Diğer özellikler

        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }

    // Address tablosu
    public class Address :AuditedAggregateRoot<Guid>
    {
        public AddressType Type { get; set; }
        public string Value { get; set; }
        // Diğer özellikler

        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }

    // ExpensePurpose tablosu
public class ExpensePurpose : AuditedAggregateRoot<Guid>
    {
        public  ExpensePurposeTybe Tybe { get; set; }
        public string value { get; set; }
        // Diğer özellikler

        public ICollection<CustomerExpensePurpose> CustomerExpensePurposes { get; set; }
    }

    // CustomerExpensePurpose tablosu
    public class CustomerExpensePurpose :AuditedAggregateRoot<Guid>
    {
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

        public Guid ExpensePurposeId { get; set; }
        public ExpensePurpose ExpensePurpose { get; set; }
    }
    //Harcama Tablosu
   

    // Telefon tipi enum'ı
    public enum ContactType
    {
        Home,
        Work,
        Mobile
    }

    // Adres tipi enum'ı
    public enum AddressType
    {
        Home,
        Work,
        workplace,
    }
    public enum ExpensePurposeTybe
    {
        Travel_expenses, 
        grocerye_xpenses,
        school_expenses,
    }
}
