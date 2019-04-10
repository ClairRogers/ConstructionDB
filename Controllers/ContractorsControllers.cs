using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using construction.Models;
using construction.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace construction.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ContractorsController : ControllerBase
  {
    private readonly ContractorsRepository _cr;
    public ContractorsController(ContractorsRepository cr)
    {
      _cr = cr;
    }

    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<Contractor>> Get()
    {
      return Ok(_cr.GetAll());
    }

    [HttpGet("{id}")]
    public ActionResult<Contractor> GetOne(string id)
    {
      return Ok(_cr.GetbyId(id));
    }


  }
}
