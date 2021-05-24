using System.Collections.Generic;
using System.Data;
using burgershack.Interfaces;
using burgershack.Models;

namespace burgershack.Repositories
{
  public class DrinksRepository : IRepo<Drink>
  {
    private readonly IDbConnection _db;
    public DrinksRepository(IDbConnection db)
    {
      _db = db;
    }

    public IEnumerable<Drink> GetAll()
    {
      throw new System.NotImplementedException();
    }
    public Drink Create(Drink data)
    {
      throw new System.NotImplementedException();
    }

    public Drink GetById(int id)
    {
      throw new System.NotImplementedException();
    }

    public Drink Update(Drink data)
    {
      throw new System.NotImplementedException();
    }
  }

}