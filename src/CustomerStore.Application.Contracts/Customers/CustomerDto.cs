using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace CustomerStore.Customers
{
    // Customer tablosu
    public class CustomerDto : AuditedEntityDto<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcKimlikNo { get; set; }
        public bool IsUnusualName { get; set; } // Sıradışı isim işareti
        public ICollection<ContactDto> Contacts { get; set; }
        public ICollection<AddressDto> Addresses { get; set; }
        public ICollection<CustomerExpensePurpose> CustomerExpensePurposes { get; set; }
    }
    // Contact tablosu
    public class ContactDto : AuditedEntityDto<Guid>
    {
        public ContactType Type2 { get; set; }
        public string Value { get; set; }
        // Diğer özellikler

        public Guid CustomerId { get; set; }
        public CustomerDto Customer { get; set; }
    }

    // Address tablosu
    public class AddressDto : AuditedEntityDto<Guid>
    {
        public AddressType Type { get; set; }
        public string Value { get; set; }
        // Diğer özellikler

        public Guid CustomerId { get; set; }
        public CustomerDto Customer { get; set; }
    }

    // ExpensePurpose tablosu
    public class ExpensePurpose : AuditedEntityDto<Guid>
    {
        public ExpensePurposeTybe Tybe { get; set; }
        public string value { get; set; }
        // Diğer özellikler

        public ICollection<CustomerExpensePurpose> CustomerExpensePurposes { get; set; }
    }

    // CustomerExpensePurpose tablosu
    public class CustomerExpensePurpose : AuditedEntityDto<Guid>
    {
        public Guid CustomerId { get; set; }
        public CustomerDto Customer { get; set; }

        public Guid ExpensePurposeId { get; set; }
        public ExpensePurpose ExpensePurpose { get; set; }
    }

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

