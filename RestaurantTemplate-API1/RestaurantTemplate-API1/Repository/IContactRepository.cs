using RestaurantTemplate_API1.Models.Information;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantTemplate_API1.Repository
{
     public interface IContactRepository
    {
        Task AddContact(ContactInformation contactInformation);
        Task<ContactInformation> GetContact(int id);
        Task<IEnumerable<ContactInformation>> GetContacts();
        Task EditContact(ContactInformation contactInformation);
        Task DeleteContact(int id);
    }
}
