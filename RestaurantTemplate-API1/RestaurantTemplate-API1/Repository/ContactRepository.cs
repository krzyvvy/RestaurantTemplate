using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RestaurantTemplate_API1.Data;
using RestaurantTemplate_API1.Models.Enity;
using RestaurantTemplate_API1.Models.Information;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantTemplate_API1.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ContactRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task AddContact(ContactInformation contactInformation)
        {
            var contact = _mapper.Map<Contact>(contactInformation);
            await _context.AddAsync(contact);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteContact(int id)
        {
            var contact = await _context.Contacts.FirstOrDefaultAsync(x => x.ContactId == id);
            _context.Remove(contact);

            await _context.SaveChangesAsync();
        }

        public async Task EditContact(ContactInformation contactInformation)
        {
            var contact = _mapper.Map<Contact>(contactInformation);
            _context.Update(contact);

            await _context.SaveChangesAsync();
        }

        public async Task<ContactInformation> GetContact(int id)
        {
            var contact = await _context.Contacts.FirstOrDefaultAsync(x => x.ContactId == id);
            return _mapper.Map<ContactInformation>(contact);
        }

        public async Task<IEnumerable<ContactInformation>> GetContacts()
        {
            var contacts = await _context.Contacts.ToListAsync();
            return _mapper.Map<IEnumerable<ContactInformation>>(contacts);
        }
    }
}
