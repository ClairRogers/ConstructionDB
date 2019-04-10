using System.Collections.Generic;
using System.Data;
using construction.Models;
using Dapper;

namespace construction.Repositories
{
  public class JobsRepository
  {
    private readonly IDbConnection _db;
    public JobsRepository(IDbConnection db)
    {
      _db = db;
    }

    public IEnumerable<Job> GetAll()
    {
      return _db.Query<Job>("SELECT * FROM jobs");
    }





  }
}