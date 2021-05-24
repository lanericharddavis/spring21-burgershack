using System.Collections.Generic;
using burgershack.Interfaces;
using burgershack.Models;

namespace burgershack.Repositories
{
    public class BurgersRepository : IRepo<Burger>
    {

        public IEnumerable<Burger> GetAll()
        {
            throw new System.NotImplementedException();
        }
        public Burger Create(Burger data)
        {
            throw new System.NotImplementedException();
        }

        public Burger GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Burger Update(Burger data)
        {
            throw new System.NotImplementedException();
        }
    }

}