using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Repositories.Users
{
  public class UserRepository : IUserRepository
  {
    private readonly DataContext _context;

    public UserRepository(DataContext context)
    {
      _context = context;
    }

    public async Task<ActionResult<List<User>>> List()
    {
      var users = await _context.Users.Include(x => x.Likes).Include(x => x.UserHeroes).Include(x => x.Avatar).ToListAsync();
      return users;
    }

    public async Task<ActionResult<User>> Read(int id)
    {
      var user = await _context.Users.Include(x => x.Likes).Include(x => x.UserHeroes).Include(x => x.Avatar).AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
      return user;
    }

    public async Task Save(User user)
    {
      var verifyUser = await _context.Users.Where(x => x.Username == user.Username).FirstOrDefaultAsync();
      if (verifyUser != null)
      {
        return;
      }
      _context.Users.Add(user);
      await _context.SaveChangesAsync();
    }
  }
}