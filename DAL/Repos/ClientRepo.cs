using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ClientRepo : Repo, IRepo<Client, int, bool>
    {
        public bool Create(Client obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Client> Get()
        {
            throw new NotImplementedException();
        }

        public Client Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Client obj)
        {
            throw new NotImplementedException();
        }
    }
}
