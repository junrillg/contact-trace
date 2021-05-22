using System.Collections.Generic;
using System.Threading.Tasks;
using ContactTrace.DataAccess.Models;

namespace ContactTrace.DataAccess
{
    public class ContactData : IContactData
    {
        private readonly ISqlDataAccess _db;

        public ContactData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<ContactModel>> GetContact()
        {
            var sql = "SELECT * FROM dbo.Contact";
            return _db.LoadData<ContactModel, dynamic>(sql, new { });

        }

        public Task InsertContact(ContactModel model)
        {
            var sql =
                @"INSERT INTO dbo.Contact (FirstName, LastName, Address) VALUES (@FirstName, @LastName, @Address)";
            return _db.SaveData(sql, model);
        }
    }
}