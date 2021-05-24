using System;
using System.Collections.Generic;
using burgershack.Models;
using burgershack.Repositories;

namespace burgershack.Services
{
  public class DrinksService
  {
    private readonly DrinksRepository _drinksRepository;
    public DrinksService(DrinksRepository drinksRepository)
    {
      _drinksRepository = drinksRepository;
    }

    internal IEnumerable<Drink> GetAll()
    {
      return _drinksRepository.GetAll();
    }
  }


}