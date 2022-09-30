
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenanIkedaFernandes_d7_avaliacao.Model;
using RenanIkedaFernandes_d7_avaliacao.Repository;
using Microsoft.EntityFrameworkCore;

namespace RenanIkedaFernandes_d7_avaliacao.Controller;
internal class UsersController
{
    private readonly AppDbContext context;
    private DbSet<User> Users;
    public UsersController(AppDbContext context)
    {
        this.context = context;
        this.Users = this.context.Users;
    }
    public bool Logon(string username, string password)
    {
        try
        {
            User? db_user = this.Users.Where(user => user.Name == username).FirstOrDefault();
            if (db_user == null)
                return false;
            if (password == db_user.Password)
                return true;
            return false;
        }
        catch
        {
            return false;
        }
    }
}

