using System.Collections.Generic;
using System.Data;
using burgershack.Interfaces;
using burgershack.Models;

namespace burgershack.Repositories
{
  public class SidesRepository : IRepo<Side>
  {
    private readonly IDbConnection _db;
    public SidesRepository(IDbConnection db)
    {
      _db = db;
    }

    public IEnumerable<Side> GetAll()
    {
      throw new System.NotImplementedException();
    }
    public Side Create(Side data)
    {
      throw new System.NotImplementedException();
    }

    public Side GetById(int id)
    {
      throw new System.NotImplementedException();
    }

    public Side Update(Side data)
    {
      throw new System.NotImplementedException();
    }
  }

}