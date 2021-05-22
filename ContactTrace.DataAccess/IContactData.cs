using System.Collections.Generic;
using System.Threading.Tasks;
using ContactTrace.DataAccess.Models;

namespace ContactTrace.DataAccess
{
    public interface IContactData
    {
        Task<List<ContactModel>> GetContact();
        Task InsertContact(ContactModel model);
    }
}