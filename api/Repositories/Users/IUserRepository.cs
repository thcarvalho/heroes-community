using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api.Models;

namespace api.Repositories.Users
{
  public interface IUserRepository
  {
    Task Save(User user);
    Task<ActionResult<List<User>>> List();
    Task<ActionResult<User>> Read(int id);
    
  }
}