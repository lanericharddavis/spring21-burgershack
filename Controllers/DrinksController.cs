using System;
using System.Collections.Generic;
using burgershack.Interfaces;
using burgershack.Models;
using burgershack.Services;
using Microsoft.AspNetCore.Mvc;

namespace burgershack.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class DrinksController : ControllerBase, ICodeWorksRestfulController<Drink>
  {
    private readonly DrinksService _drinksService;

    public DrinksController(DrinksService drinksService)
    {
      _drinksService = drinksService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Drink>> GetAll()
    {
      try
      {
        IEnumerable<Drink> drinks = _drinksService.GetAll();
        return Ok(drinks);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Drink> Create()
    {
      throw new NotImplementedException();
    }

    [HttpGet]
    public ActionResult<Drink> GetById()
    {
      throw new NotImplementedException();
    }

    [HttpPut]
    public ActionResult<Drink> Update()
    {
      throw new NotImplementedException();
    }

    [HttpDelete]
    public ActionResult<Drink> Delete()
    {
      throw new NotImplementedException();
    }
  }

}
