using RestaurantTemplate_API1.Models.Information;
using RestaurantTemplate_API1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantTemplate_API1.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _repository;

        public ContactService(IContactRepository repository)
        {
            _repository = repository;
        }

        public async Task AddContact(ContactInformation contactInformation)
        {
            await _repository.AddContact(contactInformation);
        }

        public async Task DeleteContact(int id)
        {
            await _repository.DeleteContact(id);
        }

        public async Task EditContact(ContactInformation contactInformation)
        {
            await _repository.EditContact(contactInformation);
        }

        public async Task<ContactInformation> GetContact(int id)
        {
            return await _repository.GetContact(id);
        }

        public async  Task<IEnumerable<ContactInformation>> GetContacts()
        {
            return await _repository.GetContacts();
        }
    }
}
