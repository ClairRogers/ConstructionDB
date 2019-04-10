using System.Collections.Generic;
using System.Data;
using construction.Models;
using Dapper;

namespace construction.Repositories
{
  public class ContractorsRepository
  {
    private readonly IDbConnection _db;
    public ContractorsRepository(IDbConnection db)
    {
      _db = db;
    }



    //returns all contractors from the database
    public IEnumerable<Contractor> GetAll()
    {
      return _db.Query<Contractor>("SELECT * FROM contractors");
    }


    public Contractor GetbyId(string Id)
    {
      return _db.QueryFirstOrDefault<Contractor>($"SELECT * FROM contractors WHERE id = @Id", new { Id });
    }


    public Contractor NewContractor(Contractor cont)
    {
      _db.Execute($"INSERT INTO contractors (id, name, rate)" + "VALUES (@Id, @Name, @Rate)", cont);
      return cont;
    }





  }
}