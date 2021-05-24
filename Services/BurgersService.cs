using System;
using System.Collections.Generic;
using burgershack.Models;
using burgershack.Repositories;

namespace burgershack.Services
{

  public class BurgersService
  {
    private readonly BurgersRepository _repo;
    public BurgersService(BurgersRepository repo)
    {
      _repo = repo;
    }

    internal IEnumerable<Burger> GetAll()
    {

      // TODO do this thing
      throw new NotImplementedException();
    }

    internal Burger GetById(int id)
    {
      Burger burger = _repo.GetById(id);
      if (burger == null)
      {
        throw new Exception("Invalid Burger Id");
      }
      return burger;
    }
  }
}