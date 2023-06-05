using CustomerStore.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace CustomerStore
{
    public class CustomerStoreDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Customer, Guid> _customerRepository;

        public CustomerStoreDataSeedContributor(IRepository<Customer, Guid> customerRepository)
        {
            _customerRepository = customerRepository;
        }
        sıra sır = new sıra();//sıra classını tanımadım.
        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _customerRepository.GetCountAsync() <= 0)
            {
                await _customerRepository.InsertAsync(new Customer

                {
                    
                    FirstName="Cebrail",
                    LastName = "Yıldırım",
                    TcKimlikNo = "11111111111",
                    IsUnusualName =sır.fonk("Cebrail"),
                    Addresses=new List<Address>
                    {
                        new Address
                        {
                            Type=AddressType.workplace,
                            Value="Mardin Nusaybin",
                        }

                    },
                  Contacts = new List<Contact>
                  {
                      new Contact
                      {
                          Type2=ContactType.Mobile,
                          Value="0546801330",
                      }
                  },
                  
                   
                  
                },
                
                autoSave:true
                  );
                
            }
        }
    }
    public class sıra
    {

        public bool fonk(string name)
        {
            int SumA = 0, SumE = 0, SumI = 0, Sumİ = 0, SumO = 0, SumÖ = 0, SumU = 0, SumÜ = 0;
            string dizi = "aAEeIıİiOoÖöUuÜü";

            foreach (var i in name)
            {
                foreach (var j in dizi)
                {
                    if (name[i] == dizi[j])
                    {
                        if (dizi[j] == 'A' || dizi[j] == 'a')
                        {
                            SumA++;
                        }
                        else if (dizi[j] == 'E' || dizi[j] == 'e')
                        {
                            SumE++;
                        }
                        else if (dizi[j] == 'I' || dizi[j] == 'ı')
                        {
                            SumI++;
                        }
                        else if (dizi[j] == 'İ' || dizi[j] == 'i')
                        {
                            Sumİ++;
                        }
                        else if (dizi[j] == 'O' || dizi[j] == 'o')
                        {
                            SumO++;
                        }
                        else if (dizi[j] == 'Ö' || dizi[j] == 'ö')
                        {
                            SumÖ++;
                        }
                        else if (dizi[j] == 'U' || dizi[j] == 'u')
                        {
                            SumU++;
                        }
                        else if (dizi[j] == 'Ü' || dizi[j] == 'ü')
                        {
                            SumÜ++;
                        }

                    }
                }

            }

            if (SumA >= 3 || SumE >= 3 || SumI >= 3 || Sumİ >= 3 || SumO >= 3 || SumÖ >= 3 || SumU >= 3 || SumÜ >= 3)
            {
                return true;
            }
            else { return false; }
        }
    }
}
