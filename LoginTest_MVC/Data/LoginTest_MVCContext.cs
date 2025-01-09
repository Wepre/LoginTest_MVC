using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LoginTest_MVC.Models;

namespace LoginTest_MVC.Data
{
    public class LoginTest_MVCContext : DbContext
    {
        public LoginTest_MVCContext (DbContextOptions<LoginTest_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<LoginTest_MVC.Models.MovieModel> MovieModel { get; set; } = default!;
    }
}
