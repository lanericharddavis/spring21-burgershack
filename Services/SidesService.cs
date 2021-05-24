using System;
using System.Collections.Generic;
using burgershack.Models;
using burgershack.Repositories;

namespace burgershack.Services
{
  public class SidesService
  {
    private readonly SidesRepository _sidesRepository;
    public SidesService(SidesRepository sidesRepository)
    {
      _sidesRepository = sidesRepository;
    }
    internal IEnumerable<Side> GetAll()
    {
      return _sidesRepository.GetAll();
    }

    internal Side GetById(int id)
    {
      Side side = _sidesRepository.GetById(id);
      if (side == null)
      {
        throw new Exception("Invalid Side Id");
      }
      return side;
    }
  }
}