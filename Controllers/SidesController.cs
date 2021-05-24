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
  public class SidesController : ControllerBase
  {
    private readonly SidesService _sidesService;

    public SidesController(SidesService sidesService)
    {
      _sidesService = sidesService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Side>> GetAll()
    {
      try
      {
        IEnumerable<Side> sides = _sidesService.GetAll();
        return Ok(sides);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    public ActionResult<Side> Create()
    {
      throw new System.NotImplementedException();
    }

    [HttpGet("{id}")]
    public ActionResult<Side> GetById(int id)
    {
      try
      {
        Side found = _sidesService.GetById(id);
        return Ok(found);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPut]
    public ActionResult<Side> Update()
    {
      throw new System.NotImplementedException();
    }

    [HttpDelete]
    public ActionResult<Side> Delete()
    {
      throw new System.NotImplementedException();
    }

  }
}
